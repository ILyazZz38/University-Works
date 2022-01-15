program project1;

type
  Klient = record//тип клиент. Фамилия, номер и деньги
    Number:integer;
    Family:String[25];
    Money:integer;
  end;

var
  i,c,y:integer;//i- для цикла for, c-для подсчета клиентов ,y-для case
  f1: file of Klient;//текстовый файл
  family:string[25];//для поиска данных клиента
  name:string;//имя текстового файла
  s:array[1..30] of Klient;//массив клиентов
begin
  c:=0;
  repeat                 
    {Реализация Меню}     
    writeln('Dannye o scetah klientov banka');
    writeln('MENU');
    writeln();
    writeln('1. Vesti klientov banka');
    writeln('2. Spisok klientov');
    writeln('3. Dannye klienta');
    writeln('4. Sohranit dannye v faile');
    writeln('5. prochitat dannye iz faila');
    writeln('6. Exit');
    writeln();
    write('Deistvye: ');
    readln(y);
  case y of
    
    {Ввод списка клиентов}
    1: begin
      writeln();
      c:=c+1;
      writeln();
     //запрашивается и сразу же вводится в массив с клиентами: фамилия, учетный номер и сумма на счету клиента
        write('Vvedite familiu ', c, ' klienta: ');
        readln(s[c].Family);
        write('vvedite uchetni nomer ', c, ' klienta: ');
        readln(s[c].Number);
        write('vvedite summu deneg na schetu ', c, ' klienta: ');
        readln(s[c].Money);
        writeln();
        writeln();
    end;
    
    {Вывод списка клиентов}
    2: begin
      writeln();
      for i:=1 to c do begin//вывод всех клиентов из массива с клиентами
        writeln('Klient ', i);
        writeln();
        writeln('Familya: ', s[i].Family);
        writeln('ucheti nomer klienta: ', s[i].Number);
        writeln('summa na schetu klienta: ', s[i].Money);
        writeln();
      end;
      writeln();
      writeln();
    end;
    
    {Данные клиента}
    3: begin
      writeln();
      write('Vvedite Familiu klienta: ');
      readln(family);
      for i:= 1 to c do begin//сравнивает все фамилии клиентов с веденной фамилией и выводит его данные
        if family = s[i].Family then begin
          writeln('Uchetni nomer klienta: ', s[i].Number);
          writeln('Summa na schetu klienta: ', s[i].Money);
          writeln();
        end
        else begin
          writeln('Takogo klienta net');//в ином случае выводится сообщение о том что такого клиента нет
        end;
      end;
      writeln();
      writeln();
    end;
    
    {Ввод данных в файл}
    4:begin
      writeln();
      write('Vvedite imya faila: ');
      readln(name);//чтение имени файла. создание файла с таким именем и открытие его для редактирования
      assign(f1, name);
      rewrite(f1);
      for i:= 1 to c do begin//вводит данные о всех клиентах в файл
        writeln(f1, s[i].Family);
        writeln(f1, s[i].Number);
        writeln(f1, s[i].Money);
      end;
      close(f1);//закрытие файла
      writeln('sozdan fail:', name);
      writeln('fail sohranen');
      writeln;
      writeln();
    end;
    
    {Вывод данных из файла}
    5:begin
      writeln;
      write('Kakoy fail zagruzit?: ');//запрос и том, какой файл загрузить
      readln(name);
      writeln();
      assign(f1, name);
      reset(f1);
      while not EOF(f1) do begin//выводит все данные о клинтах, пока файл не будет закончен
        readln(f1, s[i].Family);
        writeln('Familiya klienta:', s[i].Family);
        readln(f1, s[i].Number);
        writeln('Uchetni nomer klienta:', s[i].Number);
        readln(f1, s[i].Money);
        writeln('Summa na schetu klienta:', s[i].Money);
        writeln;
       end;
      close(f1);
      writeln;
      writeln();
   end;
   {В случае выбор пункта не из меню}
   else begin
     writeln;
     writeln('Vvedite chislo iz menu!');
     writeln;
   end;
   end;
 {условие для завершения программы}
 until y = 6;
end.           