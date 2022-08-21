using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // "Hello World!"를 출력하는 코드
            Console.WriteLine("고명조"); // 출력
            //string str = Console.ReadLine(); // 키보드 입력을 받아서 str이라는 string 변수에 저장한다.

            // 변수 : 변하는 수 
            // 변수의 종류 : 데이터 타입(Data Type)
            // int : 인티저, 정수, 소수점 없는 숫자, 32bit
            // float : 플로트, 실수, 소수점 있는 숫자, 32bit
            // string : 스트링. 문자열, 글자들을 저장
            // bool : 불 또는 불리언, true/false를 저장

            int a = 10; // a라는 인티저 정수에 10이라는 데이터를 넣는다.
            // long b = 5000000000; 50억은 int에 넣을 수 없다 => int는 32비트이고 32비트로 표현가능한 숫자의 갯수는 2^32(4,294,967,296)
            int c = -100;
            int d = 200000000;
            int e = 200000000;
            int f = d + e;

            Console.WriteLine(f);

            //float의 단점 : 태생적으로 오차가 있을 수 밖에 없디
            float aa = 0.000123f; //★float는 끝에 꼭 f를 붙여야 한다★
            float ab = 0.9999999999f;
            float ac = 0.0000000001f;
            float ad = ab + ac; //결과가 1이 아닐 수 있다.
            Console.WriteLine(ad);

            string str1 = "Hello";
            string str2 = "안녕!";
            string str3 = $"Hello {a}"; // "Hello 10"
            Console.WriteLine(str3);
            string str4 = str1 + str2; // "Hello안녕!"
            Console.WriteLine(str4);

            bool b1 = true;
            bool b2 = false;

            int level = 1;
            int hp = 10;
            float exp = 0.9f;
            string name = "너굴맨";
            // 실습 : 아래 문장을 출력하는 코드를 작성하라 
            // 너굴맨의 레벨은 1이고 HP는 10이고 exp는 0.9다.
            string result = $"{name}의 레벨은 {level}이고 HP는 {hp} 이고 exp는 {exp}다.";
            Console.WriteLine(result);
            Console.WriteLine($"{name}의 레벨은 {level}이고 HP는 {hp} 이고 exp는 {exp}다.");
            Console.WriteLine($"이름 : {name}\n레벨 : {level}\nHP : {hp}\nexp : {exp}");

            Console.Write("아름을 입력하세요 : ");
            name = Console.ReadLine();
            Console.Write($"{name}의 레벨을 입력하세요 : ");
            // level = Console.ReadLine(); => level은 문자형이 아닌 정수형이라 오류
            string temp = Console.ReadLine();
            // level = int.Parse(temp);  string을 int로 변경해주는 코드(숫자로 바꿀 수 있을 때만 가능) ex) 123 O, 1_2 X, cx2 X , 간단하지만 위험함
            // level = Convert.ToInt32(temp); string을 int로 변경해주는 코드 (숫자로 바꿀 수 있을때만 가능) 더 세세하게 변경가능
            int.TryParse(temp, out level); // string을 int로 변경해주는 코드 (숫자로 바꿀 수 없으면 0으로 만든다,  안전 

            result = $"{name}의 레벨은 {level}이고 HP는 {hp} 이고 exp는 {exp}다.\n";
            Console.WriteLine(result);

            exp = 0.959595f;
            //너굴맨의 레벨은 1이고 HP는 10이고 exp는 90%다.
            result = $"{name}의 레벨은 {level}이고 HP는 {hp} 이고 exp는 {exp * 100:F3}%다.\n"; //exp*100을 소수점 3자리 까지 찍어주는 코드
            Console.WriteLine(result);

            //이름, 레벨, hp. 경험치를 각각 입력받고 출력하는 코드 만들기

            string name2;
            int level2;
            int hp2;
            float exp2;
            string temp2;

            Console.Write("이름을 입력하세요 : ");
            name2 = Console.ReadLine();

            Console.Write("레벨을 입력하세요 : ");
            temp2 = Console.ReadLine();
            int.TryParse(temp2, out level2);

            Console.Write("hp를 입력하세요 : ");
            temp2 = Console.ReadLine();
            int.TryParse(temp2, out hp2);

            Console.Write("경험치를 입력하세요 : ");
            temp2 = Console.ReadLine();
            float.TryParse(temp2, out exp2);

            string result2 = $"{name2}의 레벨은 {level2}이고 HP는 {hp2} 이고 exp는 {exp2 * 100:F2}%다.\n";
            Console.WriteLine(result2);


            //제어문(Control statement)
            //실행되는 코드 라인을 변경할 수 있는 코드
            int hp3;

            Console.Write("hp를 입력하세요 : ");
            temp2 = Console.ReadLine();
            int.TryParse(temp2, out hp3);

            if (hp3 < 3) // hp3가 3보다 작을때 참이다. 
            {
                Console.WriteLine("HP가 부족합니다");
            }
            else if (hp3 < 10) // (hp3 < 3)는 거짓이고 (hp3 < 10)은 참일때 실행되는 코드
            {
                Console.WriteLine("HP가 적당합니다.");
            }
            else // (hp3 < 3)와(hp3 < 10)가 거짓일때 실행되는 코드
            {
                Console.WriteLine("HP가 충분합니다.");
            }

            switch (hp3)
            {
                case 0: //hp3가 0일때
                    Console.WriteLine("YOU DIE");
                    break;
                case 5: //hp3가 5일때
                    Console.WriteLine("HP가 5입니다.");
                    break;
                default:
                    Console.WriteLine("HP가 0과 5가 아닙니다.");
                    break;
            }

            // 실습 : exp의 값과 추가로 입력받은 경험치의 합이 1이상이면 "레벨업" 이라고 출력하고 1미만이면 합계를 출력하는 코드 작성하기

            float exp3;
            Console.WriteLine("\n경험치를 추가합니다.");
            Console.Write("추가할 경험치 : ");

            string temp3 = Console.ReadLine();
            float.TryParse(temp3, out exp3);
            float resultExp = exp2 + exp3;

            if (resultExp >= 1f)
            {
                Console.WriteLine("↑↑↑↑↑↑↑↑↑↑↑\n↑↑↑↑레벨업↑↑↑↑\n↑↑↑↑↑↑↑↑↑↑↑");
            }
            else
            {
                Console.WriteLine($"현재 경험치 : {resultExp}%\n");
            }


            while (level2 < 3) // 소괄호 안의 조건이 참이면 중괄호{} 사이의 코드를 실행하는 statement
            {
                Console.WriteLine($"\n현재 레벨 : {level2}");
                level2++; // leve2 = level2 +1; // level2 +=1;
                          // level += 2; => level에다 2를 더해서 level에 넣어라
            }


            for (int i = 0; i < 3; i++) // i는 0에서 시작해서 3보다 작으면 계속 {}사이의 코드를 실행할 때마다 1씩 증가한다.
            {
                Console.WriteLine($"현재 HP : {hp2}");
                hp2 += 10;
            }
            Console.WriteLine($"최종 HP : {hp2}\n");


            do
            {
                Console.WriteLine($"현재 레벨 : {level2}");
                if (level2 == 2) // 1+1=2 
                {
                    break;
                }
                level2++;
            }
            while (level2 < 10);
            Console.WriteLine($"\n최종 Level : {level2}");


            //실습 : exp가 1을 넘어 레벨업을 할 때까지 계속 추가 경험치를 입력하도록 하는 코드를 작성하기
            float exp4 = 0.0f;
            Console.WriteLine($"\n현재 경험치 : {exp4}");

            while (1.0f > exp4) // exp4 값이 1보다 작으면 계속 반복
            {
                Console.WriteLine($"경험치를 추가해야합니다. 현재 경험치 : {exp4}");
                Console.Write("추가할 경험치  : ");
                string temp4 = Console.ReadLine(); //입력 받기
                float exp5;
                float.TryParse(temp4, out exp5); //입력받은 string을 float로 변경

                exp4 += exp5; // 입력받은 값을 exp4에 추가

            }
            //while이 끝났다라는 이야기는 exp가 1보다 크커나 같아졌다는 의미
            Console.WriteLine("레벨업★"); ;


            //함수의 구성요소
            //이름 : 함수들을 구분하기 위한 이름 (예제의 Sum)
            //리턴타입 : 함수의 실행 결과로 돌려주는 데이터의 타입 (int, 함수의 이름앞에 표시된다.)
            // 파라메터(매개변수) : 함수가 실행될 때 외부에서 받는 값 (예제의(int a, int b) 두개의 파라메터가 있다. 함수이름 뒤에 표시)
            // 함수바디 : 함수가 호출될 때 실행될 코드들 (예제의 222~225라인)

            // 함수의 이름, 리턴 타입, 파라메터를 합쳐서 함수 프로토타입. 함수의 주민등록번호. 절대로 하나의 프로그램 안에서 겹치지 않는다.

            //★break point (단축키 F9)★

            //static int Sum(int a, int b)
            //{
            //    int result = a + b;
            //    result result;
            //}

            //void Print() // 리턴해주는 값이 없고, 파라메터도 없는 경우
            //{
            //    Console.WriteLine("Print");
            //}

            //int sumResult = Sum(10, 20); // break point (단축기 F9)
            //Console.WriteLine($"SumResult : {sumResult}");

            //Print();

            //string name = "너굴맨";

            //int level = 2;
            //int hp = 10;
            //int maxHP = 20;
            //float exp = 0.1f;
            //float maxExp = 1.0f;

            ////PrintCharacter();

            //private static void PrintCharacter(string name, int level, int hp, int maxHP, float exp, float maxExp)
            //{
            //    // 실습 : 파라메터로 받은 데이터를 적당한 양식으로 출력해주는 함수 완성하기
            //}

            //Console.WriteLine(str);

            Console.ReadKey(); // 키 입력을 대기하는 코드
        } //Main 함수의 끝
    }
}

// Alt + ↑↓ : 줄 바꾸기
// Shift + end : 처음부터 끝까지 선택
// Home : 맨 처음커서