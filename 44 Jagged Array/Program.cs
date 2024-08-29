using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _44_Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //다차원 배열
            //new int[3, 4]; // 3행, 4열의 다차원 배열 생성
            //int[,] arr = new int[3, 2]; //배열 초기화

            /*
             * 3행, 2열
             * 10 0
             * 0 20
             * 0 0
             */

            //arr[0, 0] = 10; //인덱스로 접근해서 값 할당
            //arr[1, 1] = 20;
            //Console.WriteLine(arr[0,0]);

            //for 문으로 2차원 배열 요소 출력하기
            //인덱스 2개가 필요하므로 [rowindex, colindex]
            //이중 for 문 사용
            //for ( int i = 0;)


            //배열 인스턴스를 만들고 변수에 할당
            //초기화 하지 않고 배열 변수를 선언하도록 선택할 경우 new 연산자를 사용하여 변수에 배열을 할당
            //int[,] array;
            //array = new int[,] { { 1, 2 }, { 3, 4 } };  //new 연산자로 배열 인스턴스를 생성 후 할당
            //array ={{1,2},{3,4},{5,6},{7,8}}; //error

            //숫자형 배열의 모든 요소는 0으로 참조형 배열은 null 로 초기화 됨

            //배열요소에 접근하기-2차원 배열의 요소에 접근하기 위해서는 두 개의 인덱스가 필요함
            //int[,] arr = new int[3, 4]; // 각 차원에 해당하는 인덱스는 0부터 n-1 까지 임. 3은 행인덱스 0부터 2까지 / 4는 열인덱스 0부터 3까지 

            //.NET  api를 사용해 차원의 길이 가지고 오기 (배열의 각 차원의 길이를 가져올 수 있는 기능이 있음)

            //Public int GetLength(int dimension); // 길이르를 결정해야 하는 array 의 0 부터 시작하는 차원
            //int[,] arr = new int[3, 4];
            //Console.WriteLine(arr.GetLength(0)); // 행에 해당하는 길이를 반환 result : 3




            //가변 배열
            //요소의 크기가 서로 다른 배열을 의미 (=배열의 배열)
            //가변 배열을 사용하려면 해당 요소의 초기화 필요
            //int[][] arr = new int[][]
            //{
            //    new int[] {1,3,5 },
            //    new int[] {2,4 },
            //    new int[] {10, 20, 30, 40 }
            //};

            //정수형2차원 배열 인스턴스 생성하고 변수 할당
            //int[,] arr = new int[3, 2]; //배열 초기화 = 배열 인스턴스를 생성하고 변수에 할당하는 것을 초기화라고 함

            /*
             * 10  0
             * 0  20
             * 0  0
             */

            //arr[0, 0] = 10;
            //arr[1, 1] = 20;

            //Console.WriteLine(arr[0,0]); //10
            //Console.WriteLine(arr[1,1]); //2

            //for  문을 사용해 2차원 배열의 모든 요소 출력하기
            //인덱스가 2개가 필요하므로 [rowIndex,colIndex]
            //이중 for 문을 사용합니다
            /*for(int i = 0; i<3; i++) //row
            {
                for(int j = 0; j < 2; j++) //col
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            */

            //2차원 배열을 초기화 하는 다양한 방법
            //int[,] arr = new int[3, 2]
            //{
            //    {1,2},
            //    {3,4},
            //    {5,6}
            //};

            //new를 생략하고 초기화
            //int[,] arr =
            //{
            //    {1,2},
            //    {3,4},
            //    {5,6}
            //};

            //for (int i = 0; i < rowTotal; i++)
            //{
            //    for (int j = 0; j < colTotal; j++)
            //    {
            //        Console.Write("{0} ", arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //.NET API 를 사용해 각 차원의 길이 알아내기
            //int rowTotal = arr.GetLength(0); //매개변수 0은 행의 길이, 1은 열의 길이
            //int colTotal = arr.GetLength(1);

            //Console.WriteLine("rowTotal : {0}", rowTotal);
            //Console.WriteLine("colTotal : {0}", colTotal);

            //가변배열 초기화
            //가변 배열 : 배열의 배열
            int[][] arr = new int[3][]; //각 요소의 값은 null로 초기화
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("-> {0}({1}) ", arr[i], arr[i] is null);
            //}

            //가변 배열을 사용하기 전에 초기화 할 것
            arr[0] = new int[3] { 1, 3, 5 };
            arr[1] = new int[2] { 2, 4 };
            arr[2] = new int[4] { 10, 20, 30, 40 };
            //가변 배열 초기화 할 때 new를 생략하면 안됨

            //for 문을 사용해 가변 배열 순회
            for (int i = 0; i < arr.Length; i++)
            {
                //각 요소는 배열
                int[] array = arr[i];
                //fot 문을 사용해 배열의 배열을 순회
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write("{0} ", array[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
