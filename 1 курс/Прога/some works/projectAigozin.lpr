//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
program projectAigozin;
const
    n = 30;//Констатнта кол-во клиентов
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
type
    Customer = record                  //Запись клиентов
        id: integer;                    //Учетный номер клиента
        fam: string[30];               //Фамилия клиента
        money: integer;               //количество денег на счету
    end;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
var
    MasCustomer: array [1..n] of Customer;    //Массив запией клиентов
    y: byte;                                 //Для кейса
    x: integer;                             //Для массива клиентов и прочего
    FileX: file of integer;                //Файл типа х

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
procedure AddCustomer(x: integer);         //Подпрограмма добавления новго пользовотеля
begin
writeln;
    if x > n then                         //Код не позволяющий вводить больше 30 клиентов с выводом сообщения о пустом месте
        writeln('No free space')
    else
        begin
            write('Enter new customer account number: ');                            //Запрос и последующее чтение учетного номера клиента
            readln(MasCustomer[x].id);
            write('Enter the last name of the new customer : ');                   //Запрос и последующее чтение фамилии клиента
            readln(MasCustomer[x].fam);
            write('Enter amount of money in the account of the new customer: '); //Запрос и последующее чтение количества денег на счету клиента
            readln(MasCustomer[x].money);
        end;
writeln;
end;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
procedure SaveInFile(x: integer); // Подпрограмма записи в типизированный файл
var
    FileCustomers: file of Customer;
    i: integer;
begin
writeln();
    assign(FileCustomers,'FileCustomers.txt');
        rewrite(FileCustomers);
    for i:= 1 to x do
        write(FileCustomers, MasCustomer[i]);
    close(FileCustomers);
writeln('Done');
writeln();
end;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
procedure LoadFromFile(x: integer); // Подпрограмма записи из типизированного файла
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
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
procedure ConclCustomer(x: integer);   //Подпрограмма вывода данных обо всех клиентах
var
    i: integer;
begin
writeln;
    for i:= 1 to x do                //Цикл вывода всех ВВЕДЕННЫХ пользователей
        begin
            writeln;
            writeln(MasCustomer[i].fam,': ');
            writeln('    Cusctomer account number: ', MasCustomer[i].id);
            writeln('    Amount on custimer account: ', MasCustomer[i].money);
            writeln;
        end;
writeln;
end;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
procedure SearchCustomer(x: integer); // Подпрограмма поиска клиента по фамилии
var
    name: string;    //Имя клиента
    i: integer;     //Для подсчета цикла for
    m: byte;       //Для вывода в случае ошибки
begin
m:= 0;
writeln;
    write('Enter last name: ');   //Чтение фамилии
        readln(name);
    for i:= 1 to x do           //Цикл проверяющий фамилию в базе данных
        begin
          if name = MasCustomer[i].fam then
          begin
              writeln(MasCustomer[i].id);
              writeln(MasCustomer[i].money);
              m:= 1;    //Показатель удачного поиска
          end;
        end;
    if m = 0 then  //Показатель неудачного поиска
        writeln('Customer not found');
writeln;
end;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
begin
    x:= 0; // Счетчик последней записи
repeat
    {МЕНЮ}
    writeln('1. New Customer');
    writeln('2. All Customers');
    writeln('3. Search Customer');
    writeln('4. Save Customers in file');
    writeln('5. Load Customers from file');
    writeln('6. Exit');
    write('Enter: ');
    readln(y);
    {Код меню (Case)}
        case y of
            1:begin
                x:= x + 1;
                AddCustomer(x);
              end;
            2:ConclCustomer(x);
            3:SearchCustomer(x);
            4:begin
                assign(FileX,'FileX.txt');//Запись счетчика в файл
                rewrite(FileX);
                write(FileX, x);
                close(FileX);
                SaveInFile(x);
              end;
            5:begin
                assign(FileX,'FileX.txt');//Вывод счетчика из файла
                reset(FileX);
                read(FileX, x);
                close(FileX);
                LoadFromFile(x);
              end;
          end;
until y = 6;
end.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
