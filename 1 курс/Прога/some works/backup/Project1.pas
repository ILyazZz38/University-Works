program Project1;

var a:array[1..100] of integer;
  i,n,y,kol1,kol2:integer;
begin
  randomize;
  kol1:=1;
  y:=0;
  repeat
    writeln('MENU');
    writeln();
    writeln('1. Generacia massiva iz 100 chisel');
    writeln('2. kol-vo polozhitelnyh chisel');
    writeln('3. Summa vseh chetnih chisel');
    writeln('4. Exit');
    writeln();
    write('Vipolnit: ');
    readln (n);
    case n of
    1:begin
    for i:=1 to 100 do
    begin
    a[i]:=random(161)-80;
    write(a[i], '   ');
    end;
    writeln();
    writeln();
    end;
    2:begin
    for i:=1 to 100 do
    begin
    if a[i] > 0 then kol1:=kol1+1
    end;
    writeln(kol1);
    kol1:=0;
    writeln();
    end;
    3:begin
    for i:=1 to 100 do
    begin
    if a[i] mod 2 = 0 then kol2:=kol2+1
    end;
    writeln(kol2);
    kol2:=0;
    writeln();
    end;
    4:y:=1;
    end;
  until y = 1;
end.

