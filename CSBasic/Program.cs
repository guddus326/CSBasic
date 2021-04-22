﻿using System;
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
        }
    }
}
