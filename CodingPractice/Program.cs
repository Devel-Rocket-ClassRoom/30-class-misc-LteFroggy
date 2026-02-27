using System;
using System.Text;

// 1. 부분 클래스 기본 문법
{
    Person person = new Person();
    person.Print();
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 부분 클래스 사용 예제
{
    Hello bello = new Hello();
    bello.Hi();
    bello.Bye();
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 정적 클래스 기본 문법
{
    Console.WriteLine($"덧셈 : {Calculator.Add(20, 10)}");
    Console.WriteLine($"뺄셈 : {Calculator.Subtract(20, 10)}");
    Console.WriteLine($"곱셉 : {Calculator.Multiply(20, 10)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 유틸리티 클래스 만들기
{
    string target = " hello world ";
    Console.WriteLine(StringHelper.CleanAndUpper(target));
    Console.WriteLine(StringHelper.Reverse(target));
    Console.WriteLine(StringHelper.IsNullOrEmpty(target));
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 닷넷의 정적 클래스 예시
{
    Console.WriteLine(Math.Sqrt(16));
    Console.WriteLine(Math.Pow(2, 3));
    Console.WriteLine(Math.Max(10, 20));
    Console.WriteLine(Math.Min(10, 20));
}

// 6. String Builder클래스의 메서드 체이닝
{
    StringBuilder sb = new StringBuilder();
    sb.Append("Hello,");
    sb.Append(" ");
    sb.Append("World!");

    string str = new StringBuilder()
        .Append("Hello,")
        .Append(" ")
        .Append("World!")
        .ToString();

    Console.WriteLine(sb.ToString());
    Console.WriteLine(str);
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 메서드 체이닝 직접 구현하기
{
    MessageBuilder mb = new MessageBuilder();
    mb.AddText("안녕하세요!");
    Console.WriteLine(mb.Build());

    MessageBuilder mb2 = new MessageBuilder();
    mb2.AddText("반갑습니다.");
    mb2.AddSpace();
    mb2.AddText("좋은");
    mb2.AddSpace();
    mb2.AddText("하루");
    mb2.AddSpace();
    mb2.AddText("되세요.");
    Console.WriteLine(mb2.Build());
    Console.WriteLine();
    Console.WriteLine();
}

// 8. 불변 객체와 메서드 체이닝
{
    Point p1 = new Point();
    p1 = p1.MoveBy(10, 10);
    p1 = p1.MoveBy(20, 20);
    p1 = p1.MoveBy(30, 30);
    Console.WriteLine(p1);
    Console.WriteLine();
    Console.WriteLine();
}

// 9. 문자열 메서드 체이닝
{
    string str = new string(" Hello World ")
        .Trim()
        .ToLower()
        .Replace(" ", "_");
    Console.WriteLine(str);
    Console.WriteLine();
    Console.WriteLine();
}

// 10. 가변 형식
{
    MutableCircle mc = new MutableCircle();
    mc.GetRadius();
    mc.Radius = 20;
    mc.GetRadius();
    Console.WriteLine();
    Console.WriteLine();
}

// 11. 불변 형식
{
    ImmutableCircle ic1 = new ImmutableCircle();
    ImmutableCircle ic2 = ic1.WithRadius(20);
    Console.WriteLine($"원본 반지름 : {ic1.Radius}");
    Console.WriteLine($"새 원 반지름 : {ic2.Radius}");
    Console.WriteLine($"원본 반지름 : {ic1.Radius}");
    Console.WriteLine();
    Console.WriteLine();
}

// 12. readonly 필드를 사용한 불변 형식
{
    Player p1 = new Player();
    Player p2 = p1.LevelUp();
    Console.WriteLine($"player1 : {p1.Name}, 레벨 {p1.Level}");
    Console.WriteLine($"player2 : {p2.Name}, 레벨 {p2.Level}");
    Console.WriteLine();
    Console.WriteLine();
}

// 13. 닷넷의 불변 형식 예시
{
    string str1 = "Hello";
    string str2 = str1.ToUpper();
    Console.WriteLine($"원본 : {str1}");
    Console.WriteLine($"수정본: {str2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 14. 종합 - 부분 클래스로 게임 캐릭터 구현
{
    Character character = new Character("용사");
    character.TakeDamage(30);
    character.Heal(10);
    Console.WriteLine();
    Console.WriteLine();
}

// 15. 종합 - 정적 클래스로 유틸리티 만들기
{
    Console.WriteLine($"계산된 데미지 : {GameHelper.CalculateDamage(20, 3)}");
    Console.WriteLine($"생존 여부 : {GameHelper.IsAlive(10)}");
    Console.WriteLine($"체력 상태 : {GameHelper.GetHealthStatus(50, 100)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 16. 종합 - 불변 형식과 메서드 체이닝 결합
{
    Vector2D myVec = new Vector2D(1, 1);
    myVec = myVec.Add(2, 3);
    myVec = myVec.Multiply(2);
    myVec = myVec.Add(-1, -2);
    Console.WriteLine($"결과 벡터 : {myVec}");
    Console.WriteLine();
    Console.WriteLine();
}