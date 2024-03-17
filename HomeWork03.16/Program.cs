//TASK1

//int temp = 20;
// if (temp < 15)
//{
//    Console.WriteLine("Hava Soyugdur");
//}
// else
//{
//    Console.WriteLine("Hava Istidir");
//}

//Task 5

//int[] arr = { 1, 4, 7, 9, 12 };
//int i = 0;
//int count = 0;
//for (i = 0; i < arr.Length; i++)
//{
//    if (arr[i] %2 != 0)
//    {
//        count += arr[i];
//    }
//}
//Console.WriteLine( count);

//TASK18

//int num = 0;
//if(num%2==0)
//    Console.WriteLine( "eded cutdur ");
//else
//    Console.WriteLine(  "eded tekdir");


//TASK 19

//int num = 41;
//if (num % 21 == 0)
//{
//    Console.WriteLine("3e ve 7ye bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}

//Task 20

//int num1 = 21;
//int num2 = 34;
//if (num1 > num2)
//{
//    Console.WriteLine(  num1);
//}
//else
//{
//    Console.WriteLine(num2);
//}


//TASK21

//string[] arr = { "ab106", "ac222", "da234", "cd876" };
//bool result = false;
//int i = 0;

//for (i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == "ab106")
//    {
//        result = true;
//        break;
//    }
//}
//if (result)
//{
//    Console.WriteLine("var");
//}
//else
//{
//    Console.WriteLine("yoxdur");
//}

//Task 2


//string month = (Console.ReadLine());
//switch (month)
//{
//    case "Yanvar":
//    case "Mart":
//    case "May":
//    case "Iyul":
//    case "Avgust":
//    case "Oktyabr":
//    case "Dekabr":
//        Console.WriteLine(31);
//        break;
//    case "Aprel":
//    case "Iyun":
//    case "Sentyabr":
//    case "Noyabr":
//        Console.WriteLine(30);
//        break;
//    case "Fevral":
//        Console.WriteLine("28 veya 29");
//        break;
//    default:
//        Console.WriteLine("bele bir ay yoxdur");
//        break;
//}

//TASK22

//int i = 1;
//int num = 90;
//int count = 0;
//for (i=1; i<num; i++)
//{
//    if (i % 15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//Daxil olunan musbet tam ededin faktorialini tapan alg

//TASK3

//int num = 5;
//int fac = 1;
//for (int i = num; i > 0; i--)
//{
//    fac = fac * i;
//}
//Console.WriteLine(fac);

//daxil edilen tam musbet ededin sade ve ya murekkeb oldugunu tapan alg

//TASK4

//int num = 12;
//int count = 0;
//for (int i = 2; i < num; i++)
//{
//    if (num % i == 0)
//    {
//        count++;
//        if (count == 1)
//        {
//            Console.WriteLine("murekkebdir");
//            break;
//        }

//    }
//    Console.WriteLine("sadedir");
//    break ;

//}

//EDEDLERDEN IBARET OLAN BIR ARRAY VERILIB.HEMIN ARRAYDA OLAN EN BOYUK EDEDI EKRANA CIXART

//Task6

//int[] arr = { 1, 5, 2, 7, 8 };
//int enB = 0;
//for(int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > enB)
//    {
//        enB = arr[i];
//    }
//}Console.WriteLine(enB);

//Verilmis 3 reqemli ededin butun reqemlerinin bir-birinden ferqli olub olmadigini yoxlayan algoritma

//task 7

//int num = 554;
//int a = num % 10;
//int b = num / 10;
//b = num % 10;
//int c = num / 100;
//if (a==b && b==c && a==c )
//{
//    Console.WriteLine("beraberdi ");
//}
//else
//{
//    Console.WriteLine("ferqlidi");
//}


//VERILMIS EDEDIN 2 NIN NECENCI QUVVETI OLDUUGNU YOXLAYAN ALGORTMA 

//TASK 8

//int num = 10;
//int count = 0;
//while (num != 0)
//{
//    num /= 2;
//    count++;
//}
//Console.WriteLine(count);


//EDEDIN REQEMLERI CEMINI TAPIN

//TASK9

//int num = 1423;
//int hide = 0;
//int count = 0;
//while (num !=0)
//{
//    hide = num % 10;
//    num /= 10;
//    count += hide;
//}
//Console.WriteLine( count);


//EDEDLERDEN IBARET ARRAYIN EN KICIK ELEMENTINI TAP

//TASK 10

//int[] arr = { 3, 9, 6, 2, 7, 1, 8 };
//int enK=arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < enK)
//    {
//        enK = arr[i];
//    }
//}
//Console.WriteLine(enK);

//EDEDLERDEN IBARET ARRAYDA NECE REQEM OLDUGUNU CAP EDIN

//TASK11

//int[] arr = { 2, 45, 5, 33, 7, 98, 3 };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < 10)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//VERILMIS IKIREQEMLI EDEDIN ONLUQLARINI VE TEKLIKLERINI MUQAYISE EDIB CAP EDIN EGER ONLUQ BOYUKDURSE ONLUQ BOYUKDUR

//TASK12

//int num = 44;
//int hide = 0;
//hide = num % 10;
//num /= 10;
//if (num > hide)
//{
//    Console.WriteLine("onluqlar boyukdur");
//}

// else if (num == hide)
//{
//    Console.WriteLine("beraberdi");
//}


//else
//{
//    Console.WriteLine("teklikler boyukdur");
//}


//ARRAYDAKI EN BOYUK EDEDLE EN KICIK EDED YERINI DEYIS


//TASK13
//int[] arr = { 1, 3, 5, 23, 15 };
//int max = 0;
//int min = 0;
//for(int i = 0; i < arr.Length; i++)
//{
//    if (arr[max]< arr[i])
//    {
//        max = i;
//    }
//    if (arr[min]> arr[max])
//    {
//        min = i;
//    }
//}
//arr[max] += arr[min];
//arr[min] = arr[max] - arr[min];
//arr[max] = arr[max] - arr[min];
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//VERILMIS EDEDIN NECE MERTEBELI OLDUGUNU YAZAN ALGORIMT

//TASK 14

//int num = 1523;
//int count = 0;
//int hide = 0;
//while (num != 0)
//{
//    hide=num % 10;
//    count++;
//    num /= 10;
//}
//Console.WriteLine(  count);


//4 reqemli eded verilib.bu reqemin evveline 7 axirina 8 elave et

//TASK 15

//int num = 1234;
//Console.WriteLine("7"+num+"8");


//3 reqemli eded verilib.bu ededin axirina hemin ededin ozunu yapisdir

//TASK 16

//int num = 654;
//Console.WriteLine(num + "" + num);

//3reqemli eded verilib .sonuna 7 elave et ve 7 faizini tap

//TASK 17

//int num = 789;
//string num1= num + "7";
//int a=Convert.ToInt32(num1);
//a = a * 7 / 100;
//Console.WriteLine(a);


//.Ədədlərdən ibarət İki array verilib. Hər iki arrayda mövcud olan elementleri ekrana çıxaran alqoritm
//(Məsələn { 4,5,9,11,15}
//ve {1,5,13,15}   hər ikisində 5 və 15 var bunlar ekrana cixmalidir)

//TASK2

//int[] a = { 2, 5, 76, 12, 43 };
//int[] b = { 5, 34, 3, 23, 12, 2 };
//for (int i = 0; i < a.Length; i++)
//{
//    for (int j = 0; j < b.Length; j++)
//    {
//       if( a[i] == b[j])
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}


//3.Siralanmamish array verilir. Verilen arrayi sort edin misal: input {5, 2, 3} output {2, 3, 5}

//task3


//int[] arr = { 43, 23, 76, 12, 83 };
//int temp = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = i+1; j<arr.Length; j++)
//    {
//        if (arr[i] > arr[j])
//        {
//            temp = arr[j];
//            arr[j]= arr[i];
//            arr[i]= temp;
//        }  
//    }
//    Console.WriteLine(arr[i]);
//}