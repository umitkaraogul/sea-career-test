-- Expected output (in any order):
-- director         number of films
-- ------------------------------
-- Michael Curtiz   2
-- Alfred Hitchcock 1
-- Steven Spielberg 0



--Solution 1
Select d.name,COUNT(m.id)"number of films" 
from directors d
left join movies m on(m.directorId=d.id)
group by d.id;

--Solution 2
Select d.name director,
(Select count(*) from movies where directorId=d.id) "number of films" 
from directors d;


---DB Script
/*
-- Suggested testing environment:
-- http://sqlite.online/

-- Example case create statement:
CREATE TABLE directors (
  id INTEGER NOT NULL PRIMARY KEY,
  name VARCHAR(30) NOT NULL
);

CREATE TABLE movies (
  id INTEGER NOT NULL PRIMARY KEY,
  name VARCHAR(30) NOT NULL,
  directorId INTEGER NOT NULL REFERENCES directors (id)
);

INSERT INTO directors(id, name) VALUES(1, 'Michael Curtiz');
INSERT INTO directors(id, name) VALUES(2, 'Alfred Hitchcock');
INSERT INTO directors(id, name) VALUES(3, 'Steven Spielberg');

INSERT INTO movies(id, name, directorId) VALUES(1, 'Casablanca', 1);
INSERT INTO movies(id, name, directorId) VALUES(2, 'Yankee Doodle Dandy', 1);
INSERT INTO movies(id, name, directorId) VALUES(3, 'Psycho', 2);

*/
