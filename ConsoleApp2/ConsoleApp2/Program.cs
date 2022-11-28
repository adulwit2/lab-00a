class Student
{
    public string nickname;
    public int weight;

    public Student(string modelnickname, int modelwight)
    {
        nickname=modelnickname;
        weight=modelwight;

    }

    static void Main(string[] args)
    {
        Student student1 = new Student("Ta", 69);
        Student student2 = new Student("Palm", 60);
        Student student3 = new Student("Kang", 82);
        Student student4 = new Student("Ley", 90);
        Student student5 = new Student("Top", 79);
        int[] weightList = { student1.weight, student2.weight, student3.weight, student4.weight, student5.weight };
        int max = weightList.Max();
        int min = weightList.Min();
        Console.WriteLine("ค่าเฉลี่ยน้ำหนักของนักศึกษาทั้งหมด"+(student1.weight+ student2.weight+ student3.weight+ student4.weight+ student5.weight)/5);
        Console.WriteLine("ชื่อและน้ำหนักของนักศึกษาที่มีน้ำหนักมากที่สุด"+max);
        Console.WriteLine("ชื่อและน้ำหนักของนักศึกษาที่มีน้ำหนักน้อยที่สุด"+min);
        Console.WriteLine("นาย อดุลวิทย์ บุตรเรียง 653450105-9");
    }
}