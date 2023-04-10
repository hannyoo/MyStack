using System;
namespace MyStack_ //같은 namespace의 제네릭 class MaStack사용을 위해 
{
    public class Program
    {
        static void Main( string[] args )
        {
            MaStack<int> maStack = new MaStack<int>(5 );

            maStack.MaPop( );

            maStack.MaPush(1);
            maStack.MaPush(2);
            maStack.MaPush(3);
            maStack.MaPush(4);
            maStack.MaPush(5);

            maStack.MaPrint( );

            maStack.MaPush(5);
            maStack.MaPush(5);

            maStack.MaPop( );
            maStack.MaPop( );
            maStack.MaPop( );ㅂ
            maStack.MaPop( );
            maStack.MaPop( );

            maStack.MaPrint( );            

        }
    }
}