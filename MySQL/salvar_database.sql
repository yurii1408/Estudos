mysqldump -uroot -proot -x -e -A -hlocalhost -P3307 -database meritoadv > backup.sql

***********************

Uma das grandes d�vidas de qualquer administrador iniciante � como fazer backup das bases de dados do MySQL, j� que os dados s�o gravados e acessados atrav�s do servidor MySQL e n�o diretamente atrav�s de arquivos, como no caso dos arquivos referentes aos sites, salvos na pasta �/var/www�, por exemplo.

As bases de dados do MySQL s�o salvas por padr�o dentro da pasta �/var/lib/mysql�. Ao criar a base de dados �phpbb�, por exemplo, ser� criada a pasta �/var/lib/mysql/phpbb�, contendo um conjunto de arquivos, referentes �s tabelas criadas.

A forma mais simples de fazer backup das bases de dados do MySQL � simplesmente salvar o conte�do da pasta �/var/lib/mysql�, criando um arquivo .tar.gz ou mesmo copiando os arquivos diretamente para outra parti��o. O maior problema � que as bases de dados s�o alteradas continuamente durante a opera��o do banco de dados, o que leva a c�pias inconsistentes. Se alguns dos arquivos dentro da pasta com a base mudam no meio da c�pia, o backup conter� uma mistura de dados novos e antigos, uma receita para o desastre.

A forma mais segura � parar o servi�o do MySQL antes de fazer o backup, garantindo assim que nada ser� alterado durante a c�pia, como no exemplo abaixo:

# /etc/init.d/mysql stop
# tar -zcvf mysql.tar.gz /var/lib/mysql/
# /etc/init.d/mysql start
O problema nesse caso � que o servi�o fica fora do ar durante alguns segundos ou minutos. Se a base de dados � usada pelo site da sua empresa, por exemplo, ele ficar� fora do ar at� que o backup seja conclu�do e o servidor MySQL volte a ser iniciado. Voc� pode agendar os backups usando o cron, para que eles sejam executados durante a madrugada, por exemplo, mas, mesmo assim, voc� vai acabar sempre perdendo algumas visitas.

A segunda op��o � fazer um backup online, sem parar o servidor. O utilit�rio mais simples (e provavelmente o mais usado) para isso � o mysqldump, que acompanha o pacote principal do MySQL.

Diferente do m�todo anterior, onde os arquivos s�o copiados diretamente, o mysqldump acessa o banco de dados por vias normais, da mesma forma que um aplicativo qualquer faria. Em outras palavras, ele n�o l� os arquivos, mas sim as informa��es armazenadas nas bases de dados. Isso permite que o backup seja consistente, mesmo que as bases de dados sejam alteradas durante o backup.

Para salvar todas as bases de dados do servidor no arquivo �backup.sql�, criado no diret�rio atual, por exemplo, o comando seria:

# mysqldump -u root -p -x -e -A > backup.sql
O �-u root -p� especifica o usu�rio que ser� usado para acessar o banco de dados. No exemplo estou fazendo um backup completo, por isso estou usando diretamente o root. A op��o �-x� trava as bases de dados no momento em que cada uma � copiada, evitando qualquer problema de inconsist�ncia, enquanto a �-e� � uma op��o de otimiza��o, que permite ao mysqldump combinar argumentos INSERT dentro das tabelas, o que torna tanto o backup quanto a restaura��o mais r�pidos. Finalizando, a op��o �-A� especifica um backup completo, de todas as bases de dados.

Se o comando parasse por a�, o mysqldump simplesmente escreveria todo o conte�do das bases de dados na pr�pria janela do terminal, resultando em uma longa exibi��o de informa��es, sem muita utilidade. Como queremos que a sa�da seja salva em um arquivo, usamos o �>�, que redireciona a sa�da para o arquivo especificado.

O arquivo �backup.sql� gerado � basicamente um arquivo de texto gigante contendo declara��es de todas as informa��es armazenadas. Voc� pode reduzir o tamanho do arquivo para um quarto (ou menos) do tamanho original compactando o arquivo, o que pode ser feito adicionando a op��o �| gzip� antes do �>� no comando, como em:

# mysqldump -u root -p -x -e -A | gzip > backup.sql.gz
Note que nesse exemplo adicionei tamb�m o �.gz� no nome do arquivo, indicando que se trata de um arquivo compactado. Para us�-lo posteriormente, voc� precisaria apenas descompactar o arquivo, usando o comando �gunzip�, como em:

# gunzip backup.sql.gz
O maior problema com estes dois comandos � que voc� precisa digitar a senha depois de rodar o comando, o que dificulta seu uso em scripts de backup autom�tico. � poss�vel eliminar a necessidade de digitar a senha especificando-a diretamente no comando, depois do �-p� (sem espa�os), como em:

# mysqldump -u root -p12345 -x -e -A | gzip > backup.sql.gz
Note que ao incluir senhas em arquivos, � extremamente importante restringir as permiss�es, de forma que apenas o root (ou o usu�rio em quest�o) tenha permiss�o para l�-lo. Qualquer outro usu�rio do servidor que tenha acesso de leitura no arquivo, poder� ler a senha e acessar o servidor MySQL.

Continuando, os comandos acima permitem fazer um backup completo de todas as bases do servidor, que poderia ser usado para restaurar os dados em uma instala��o limpa do MySQL. � poss�vel tamb�m fazer backups localizados, contendo apenas uma base de dados espec�fica.

Nesse caso, em vez de usar a op��o �-A�, voc� usaria a op��o �-B�, seguida pela base de dados a ser salva, como em:

# mysqldump -u root -p -x -e -B phpbb > phpbb.sql
Na hora de restaurar o backup, deixamos de usar o mysqldump e passamos a utilizar o cliente mysql, que se encarrega de ler os comandos e os dados adicionados nos arquivos e us�-los para povoar as bases de dados. O comando ficaria ent�o:

# mysql -u root -p �database=phpbb < phpbb.sql
Voc� pode tamb�m especificar a senha diretamente no comando, assim como no caso do mysqldump, como em:

# mysql -u root -p12345 �database=phpbb < phpbb.sql
Se voc� tentar restaurar o backup sobre uma base de dados contendo dados, provavelmente receber� uma mensagem de erro logo no in�cio do processo, avisando que uma das tabelas j� existe, como em:

ERROR 1050 at line 19: Table �wp_comments� already exists
A solu��o no caso � remover a base de dados antiga usando o cliente MySQL e criar outra em branco para ent�o fazer a restaura��o, como em:

# mysql -u root -p
Enter password:
Welcome to the MySQL monitor. Commands end with ; or g.
Your MySQL connection id is 18
Server version: 5.0.32-Debian_7etch5-log Debian etch distribution
Type �help;� or �h� for help. Type �c� to clear the buffer.
mysql> DROP DATABASE phpbb;
Query OK, 0 rows affected (0.00 sec)
mysql> CREATE DATABASE phpbb;
Query OK, 1 row affected (0.00 sec)
mysql> exit
Bye
# mysql -u root -p �database=phpbb < phpbb.sql
Outra op��o seria adicionar a op��o ��add-drop-table� ao gerar o backup com o mysqldump. Ela faz com que ele inclua instru��es para que as bases sejam exclu�das e recriadas automaticamente durante a restaura��o, evitando que voc� precise faz�-lo manualmente. O comando ficaria ent�o:

# mysqldump �add-drop-table -u root -p -x -e -B phpbb > phpbb.sql
O comando para restaurar continua o mesmo, com a diferen�a de que voc� n�o precisa mais dar o DROP DATABASE; CREATE DATABASE antes de fazer a restaura��o.

Esta op��o pode ser adicionada tamb�m ao comando para fazer o backup completo das bases de dados, facilitando assim sua restaura��o:

# mysqldump �add-drop-table -u root -p -x -e -A > backup.sql
O backup poderia ser ent�o restaurado diretamente usando o comando abaixo, sem que voc� precisasse remover as bases e tabelas manualmente antes de iniciar a recupera��o:

# mysql -u root -p < backup.sql
O backup usando o mysqldump e a restaura��o usando o mysql s�o prefer�veis � c�pia manual dos arquivos da pasta �/var/lib/mysql�, pois evita problemas de incompatibilidade ao migrar os dados para vers�es diferentes do MySQL. Al�m disso, a facilidade de fazer o backup sem precisar parar o servidor � uma grande vantagem em um ambiente de produ��o.