desc Material;
INSERT INTO Material(MaterialType,Link,Title,Image) VALUES (1,'~/assets/1000-frases-mais-usadas-no-ingles.pdf','1000 Frases Mais Usadas No Ingles','https://www.baixelivros.com.br/media/2022/02/ingles-aplicado-eventos.jpg');
INSERT INTO Material(MaterialType,Link,Title,Image) VALUES (1,'~/assets/ingles-aplicado-a-eventos.pdf','Ingles Aplicado A Eventos','https://www.baixelivros.com.br/media/2022/02/ingles-aplicado-eventos.jpg');

SELECT * FROM Material;
SHOW tables;
desc Quiz;
INSERT INTO Quiz(Correct,Questions,FirstOption,SecondOption,ThirdOption) VALUES (1,'Qual é a forma correta do verbo "to be" na terceira pessoa do singular no presente simples?','is','are','am');
INSERT INTO Quiz(Correct,Questions,FirstOption,SecondOption,ThirdOption) VALUES (3,'Qual das seguintes palavras é um pronome pessoal no caso objetivo?','she','we','me');
INSERT INTO Quiz(Correct,Questions,FirstOption,SecondOption,ThirdOption) VALUES (2,'Qual é a forma correta do comparativo de superioridade do adjetivo "good" (bom)?','goodest','better','best');
INSERT INTO Quiz(Correct,Questions,FirstOption,SecondOption,ThirdOption) VALUES (2,'Qual é o sinônimo correto para a palavra "happy" (feliz)?','tired','pleased','confused');
INSERT INTO Quiz(Correct,Questions,FirstOption,SecondOption,ThirdOption) VALUES (2,'Qual das seguintes opções contém apenas preposições?" (feliz)?','on, at, in','dog, cat, bird','run, jump, play');

SELECT * FROM Quiz;