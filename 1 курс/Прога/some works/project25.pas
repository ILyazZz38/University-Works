program project25;
const
  n = 30;
type
  Customer = record
    id: integer;
    fam: string[30];
    money: integer;
  end;
var
  MasCustomer: array [1..n] of Customer;
  y: byte;
  x: integer;
  FileX: file of integer;


procedure AddCustomer(x: integer);// поlпрограмм ввода нового пользователя с проверкой свободного места в массиве (возможно ли изменять глобальные переменные в подпрограмме?)
begin
writeln;
  if x > n then // контроль количества записей
    writeln('No free space')
  else
    begin
      write('Enter new customer account number: ');
        readln(MasCustomer[x].id);
      write('Enter the last name of the new customer : ');
        readln(MasCustomer[x].fam);
      write('Enter amount of money in the account of the new customer: ');
        readln(MasCustomer[x].money);
    end;
writeln;
end;

procedure ConclCustomer(x: integer); // подсчет зарплаты работников
var
  i: integer;
begin
writeln;
  for i:= 1 to x do
    begin
      writeln;
      write(MasCustomer[i].fam,': ');
      writeln('Cusctomer account number: ', MasCustomer[i].id);
      writeln('Amount on custimer account: ', MasCustomer[i].money);
      writeln;
    end;
writeln;
end;

procedure SearchCustomer(x: integer); // поиск работника по фамилии
var
  name: string;
  i: integer;
  prov: byte;
begin
prov:= 0;
writeln;
  write('Enter last name: ');
    readln(name);
  for i:= 1 to x do
    begin
      if name = MasCustomer[i].fam then
        begin
          writeln(MasCustomer[i].id);
          writeln(MasCustomer[i].money);
          prov:= 1;
        end;
    end;
  if prov = 0 then
    writeln('Not found');
writeln;
end;

procedure SaveInFile(x: integer); // запись в типизированный файл
var
  FileCustomers: file of Customer;
  i: integer;
begin
writeln();
  assign(FileCustomers,'FileCustomers.txt');
    rewrite(FileCustomers);
  for i:= 1 to x do  // цикл с известным числом повторов для уменьшения размера создаваемого файла (и немного из-за лени, в основном из-за лени)
    write(FileCustomers, MasCustomer[i]);
  close(FileCustomers);
writeln('Done');
writeln();
end;

procedure LoadFromFile(x: integer); // запись из типизированного файла
var
  FileCustomers: file of Customer;
  i: integer;
begin
writeln();
  assign(FileCustomers,'FileCustomers.txt');
    reset(FileCustomers);
  for i:= 1 to x do
    read(FileCustomers, MasCustomer[i]);
  close(FileCustomers);
writeln('Done');
writeln();
end;

begin
  x:= 0; // счетчик последней записи в массиве работников
// ------------------- Меню начало ------------------- //
repeat
  writeln('1. New Customer');
  writeln('2. All Customers');
  writeln('3. Search Customer');
  writeln('4. Save Customers in file');
  writeln('5. Load Customers from file');
  writeln('6. Exit');
// ------------------- Меню конец ------------------- //
    write('Enter: ');
    readln(y);
      case y of
        1:begin
            x:= x + 1;
            AddCustomer(x);
          end;
        2:ConclCustomer(x);
        3:SearchCustomer(x);
        4:begin
            assign(FileX,'FileX.txt');// запись счетчика в файл
              rewrite(FileX);
              write(FileX, x);
              close(FileX);
            SaveInFile(x);
          end;
        5:begin
            assign(FileX,'FileX.txt');// вывод счетчика из файла
              reset(FileX);
              read(FileX, x);
              close(FileX);
            LoadFromFile(x);
          end;
      end;
until y = 6;
end.

