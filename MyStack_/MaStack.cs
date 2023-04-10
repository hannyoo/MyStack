using System;
namespace MyStack_
{
	public class MaStack<T>		//제네릭 클래스로 선언 , T (transform 선언하는 타입에 맞춰서 변환됨)
	{
        private T[] elements;
		private int top;	//마지막 data 인덱스

		public MaStack( int size )	//size를 인자값으로 받음
		{
			elements = new T[size];		//인자값으로 받은 size가 배열의 크기로 설정
            top = -1;	//마지막 data의 인덱스 값을 -1로 초기화
		}

		public void MaPush(T item)	//제네릭 클래스 T의 item(변수)를 data로 받음 , 삽입
		{
			if(top >= elements.Length-1)	//마지막 data의 인덱스 값이 배열의 크기보다 클때 = data가 꽉 찼을 때
			{
				Console.WriteLine("풀뱅!");
				return;		// 더 data를 추가하지 않고 그대로 리턴
			}
			elements[++top] = item;	 //top == -1(data 없음) 한칸 이동 elements의 0(0번째)로 이동 , itemㅇ elements의 0번째에 저장;
        }

		public T MaPop()	// item(data)제거
		{
			if(top < 0)		// data의 마지막 인덱스(top)가 0보다 작을떄 = data가 없을 때
            {
				Console.WriteLine("텅~");
				return default(T);	//null 리턴 (문법)default(T):타입에 맞는 null로 선언;
			}
			T item = elements[top];		//item이 elements의 마지막 인덱스에 저장; 
			elements[top--] = default(T);	//elements의 마지막 인덱스가 -1됨 = data가 한개 줄어들고 줄어든 곳에 null 선언;

			return item;	//elements의 마지막 인덱스 데이터 리턴
		}

		public void MaPrint()	// data 읽기
		{
            if(top < 0)		 // data의 마지막 인덱스(top)가 0보다 작을떄 = data가 없을 때
            {
                Console.WriteLine("텅!");
                return;		// 더 data를 추가하지 않고 그대로 리턴
            }
       
            for(int i = 0; i < elements.Length; i++)	// 0 - elements의 데이터 크기 만큼 차례대로 i값 증가
			{
				Console.Write($"{elements[i]} ");	//elements의 data 순서대로 출력
			}
			Console.WriteLine();
		}

	}
}

