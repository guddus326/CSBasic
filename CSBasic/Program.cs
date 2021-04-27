using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{

    class Program
    {
        //var 키워드는 지역변수로만 사용 가능하다
        //var name="함형연";
        //var something = "!@!@!@";

        static void Main(string[] args)
        {
            // keyword
            //int as;

            // context keyword
            var name = "함형연";
            //var var = "함형연";
            //var abcs = "asdf";

            // 식별자 Identifier 
            int alpha;
            int Alpha;
            //int break;
            //int 263alpha;
            //int has space;
            //int 🤣❤😒;
            int 한글숫자;

            // inline commnet 
            /*
             * comment
             */

            // 출력
            Console.Write("이건 안개행");
            Console.Write(" 입니당\n");
            Console.WriteLine("");
            Console.WriteLine("이건 개행");

            // 자료형(Data Type)
            // Integer 
            Console.WriteLine(53 + 272 - 123);
            Console.WriteLine(53 * 3 - 3);
            Console.WriteLine(14 / 2); // 7
            Console.WriteLine(14 / 3); // 4
            Console.WriteLine(14 % 3); // 2

            // Real Number
            Console.WriteLine(13.123);

            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine(14.0 / 2.0); // 7.0
            Console.WriteLine(14.0 / 3.0); // 4.6666667
            //Console.WriteLine(14.0 % 3.0);
            Console.WriteLine(14 / 3);  // 4
            Console.WriteLine(14.0 / 3); // 4.6666667
            Console.WriteLine(14 / 3.0); // 4.6666667
            Console.WriteLine(14.0 / 3.0); // 4.6666667

            // Character 
            Console.WriteLine('A'); // 문자
            // String
            Console.WriteLine("A"); // 문자열
            // Escape Character 
            Console.WriteLine("\t 탭 \\ 역슬래시 \n 개행 \" ");
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보과\t학고");
            Console.WriteLine("미림여자정보과학고\t");

            //문자열 연결 연산자
            //concat concatenate operator
            //concatenation operator
            Console.WriteLine("ABC" + "DEF");
            Console.WriteLine('A' + 'E');//134
            Console.WriteLine("ABC" + 'E');//ABCE

            Console.WriteLine("ABC"[2]);
            //Console.WriteLine("ABC"[3]);

            //bool
            bool isPlay = true;
            bool isDeath = false;

            //comparison operator
            Console.WriteLine(52 == 164);
            Console.WriteLine(52 != 164);
            Console.WriteLine(52 > 164);
            Console.WriteLine(52 < 164);
            Console.WriteLine(52 >= 164);//=>이렇게 쓰지 않도록 주의
            Console.WriteLine(52 <= 164);

            // Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            //단항연산자 - unary operator
            Console.WriteLine(!(true));
            int i = 0;
            i++;

            //이항연산자 - binary operator
            i = 1 + 2;

            //삼항연산자 - ternary operator
            int j;
            //[1] ? [2] : [3]
            j=(i>3)?0:1;
            Console.WriteLine(3 > i && i < 8);
            Console.WriteLine(3 > i || i < 8);
            Console.WriteLine(i <3  || 8 < i);

            int a = 2114748350;
            int b = 100000000;
            Console.WriteLine((long)a + b);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MaxValue);
            
            Console.WriteLine(-int.MaxValue);
            //Console.WriteLine(-int.MinValue);

            Console.WriteLine(3L);

            Console.WriteLine(3);
            Console.WriteLine(3.0);
            char c = 'a';
            Console.WriteLine(c);

            //sizeof(자료형)
            Console.WriteLine("int" + sizeof(int));
            Console.WriteLine("int" + sizeof(long));
            Console.WriteLine("int" + sizeof(float));
            Console.WriteLine("int" + sizeof(double));
            Console.WriteLine("int" + sizeof(char));

            bool isLive = true;

            //증감연산자 - 섞어서 쓸 경우
            //전위 후위에 따라서 출력값이 변할 수 있으니 주의

            int num = 10;
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);

            //복합대입연산자
            int output = 0;
            output += 52;
            output = output + 52;
            output *= 10;
            output = output * 10;
            Console.WriteLine(output);

            //문자열 연결 연산자를 사용한 복합 연산자
            string output3 = "Hello";
            output3 += " World";
            output3 = output3 + "?!";
            Console.WriteLine(output3);


            int _int = 284;
            long _long = 4235252525252;
            float _float=6.234F;
            double _double = 52.234;
            char _char = '귤';
            string _string = "문자열";
            Console.WriteLine(_int.GetType());//System.Int32
            Console.WriteLine(_long.GetType());//System.Int64
            Console.WriteLine(_float.GetType());//System.Single
            Console.WriteLine(_double.GetType());//System.Double
            Console.WriteLine(_char.GetType());//System.Char
            Console.WriteLine(_string.GetType());//System.String


           /* var somea = "집가고싶다";
            var someb = 42;
            var somec = 3.14159262;
            Console.WriteLine(somea.GetType());
            Console.WriteLine(someb.GetType());
            Console.WriteLine(somec.GetType());

 
            string input;
            while (true)
            {
                Console.Write("입력>");
                input = Console.ReadLine();
                if (input.Equals("Q"))             
                    break;              
                else           
                    Console.WriteLine(input);
            }*/

            var a1 = (int)10.0;
            var b1 = (float)10;
            var c1 = (double)10;

            long longNumber = 231434352345L + 2313453442345L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            long longNumber2 = 52344;
            int intNumber2 = (int)longNumber2;
            Console.WriteLine(intNumber2);//강제형변환한다고 무조건 데이터가 훼손되는건 아니다

            Console.WriteLine("int, long, float. double 맥스벨류");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("문자열의 숫자로의 형변환");
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));
            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());

            //잘못된 형변환
            try {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("abc"));
                Console.WriteLine(int.Parse("육십삼"));
                Console.WriteLine(int.Parse("seven"));
            }catch(FormatException e)
            {
                Console.WriteLine("숫자를 입력하세요 : "+e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("알 수 없는 에러 : "+e.Message);
            }

            //ToString()
            (10).ToString();
            (52.283).ToString();
           
            double numberToString = 52.273103;
            Console.WriteLine(numberToString.ToString("0.0"));//반올림 해준다
            Console.WriteLine(numberToString.ToString("0.00"));
            Console.WriteLine(numberToString.ToString("0.000"));
            Console.WriteLine(numberToString.ToString("0.0000"));

            //숫자와 문자열 덧셈
            Console.WriteLine(52 + 274);
            Console.WriteLine("52" + 274);
            Console.WriteLine(52 + "274");
            Console.WriteLine("52" + "274");
            Console.WriteLine(52 + 2+ 274);
            Console.WriteLine(52 + "2" + 274);
            Console.WriteLine("52" + 2 + 274);
            Console.WriteLine(52 + 2 + "274");
            Console.WriteLine(52 + '1' + "274");

            int number = 52273;
            string outputA = number + "";

            char character = 'a';
            string outputB = character+"";
            Console.WriteLine(outputB);

            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("truE"));
            Console.WriteLine(bool.Parse("TrUe"));

            int outputInt = int.MaxValue;
            //Console.WriteLine(outputInt);마이너스 안나옴
            Console.WriteLine(-(long)outputInt);
            Console.WriteLine();






        }
    }
}
