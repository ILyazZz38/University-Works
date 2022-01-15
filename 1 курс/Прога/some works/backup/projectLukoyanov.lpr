program projectLukoyanov;
const
  n = 50;
type
  book = record
    autor: string[30];
    bname: string[30];
    kol: integer;
  end;
var
  mbook: array [1..n] of book;
  ans: byte;
  sch: integer;
  fsch: file of integer;

procedure abook(sch: integer);// полпрограмм ввода новой книги с проверкой свободного места в массиве
begin
writeln;
  if sch > n then // контроль количества записей
    writeln('Net mesta')
  else
    begin
      write('Vvedite novuy knigu: ');
        readln(mbook[sch].bname);
      write('Vvedite avtora: ');
        readln(mbook[sch].autor);
      write('Skolko knig vsego: ');
        readln(mbook[sch].kol);
    end;
writeln;
end;

procedure cbook(sch: integer); // Вывод книг
var
  i: integer;
begin
writeln;
  for i:= 1 to sch do
    begin
      write(mbook[i].bname,': ');
      writeln('avtor - ',mbook[i].autor ,' vsego knig - ',mbook[i].kol);
    end;
writeln;
end;

procedure sbook(sch: integer); // поиск книги по фамилии
var
  name: string;
  i: integer;
  prov: byte;
begin
writeln;
  write('Vvedite avtora knigi: ');
    readln(name);
  for i:= 1 to sch do
    begin
      if name = mbook[i].autor then
        begin
          writeln(mbook[i].bname);
          writeln(mbook[i].kol);
        end;
    end;
end;

procedure savebook(sch: integer); // запись в типизированный файл
var
  filebooks: file of book;
  i: integer;
begin
writeln();
  assign(filebooks,'filebooks.txt');
    rewrite(filebooks);
  for i:= 1 to sch do  // цикл с известным числом повторов для уменьшения размера создаваемого файла (и немного из-за лени, в основном из-за лени)
    write(filebooks, mbook[i]);
  close(filebooks);
writeln();
end;

procedure loadbook(sch: integer); // запись из типизированного файла
var
  filebooks: file of book;
  i: integer;
begin
writeln();
  assign(filebooks,'filebooks.txt');
    reset(filebooks);
  for i:= 1 to sch do
    read(filebooks, mbook[i]);
  close(filebooks);
writeln();
end;

begin
  sch:= 0; // счетчик последней записи в массиве работников
//Меню
repeat
  writeln('1. Novaya kniga');
  writeln('2. Vse knigi');
  writeln('3. Naiti knigu');
  writeln('4. Sohr v faile');
  writeln('5. Zogr s faila');
  writeln('6. Konec');
    write('Vvod: ');
    readln(ans);
      case ans of
        1:begin
            sch:= sch + 1;
            abook(sch);
          end;
        2:cbook(sch);
        3:sbook(sch);
        4:begin
            assign(fsch,'fsch.txt');// запись счетчика в файл
              rewrite(fsch);
              write(fsch, sch);
              close(fsch);
            savebook(sch);
          end;
        5:begin
            assign(fsch,'fsch.txt');// вывод счетчика из файла
              reset(fsch);
              read(fsch, sch);
              close(fsch);
            loadbook(sch);
          end;
      end;
until ans = 6;
end.

