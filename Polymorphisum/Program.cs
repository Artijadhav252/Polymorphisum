using Polymorphisum;

public class Program
{
    public static void Main()
    {
        //Doctor doctor = new Doctor();
        //doctor.Operation("Heart Surgery");

        Arithmetic arithmetic = new Arithmetic();
        //arithmetic.add(10, 20);
        //arithmetic.add(2.5f, 3.5f);
        //arithmetic.add(2.5f, 10f);
        //arithmetic.add(1, 2, 3);


        //arithmetic.sub(2, 1);
        //arithmetic.sub(3, 2.5f);
        //arithmetic.sub(2, 3, 4);

        //arithmetic.mul(2, 3);
        //arithmetic.mul(2, 2.5f);
        //arithmetic.mul(2, 3, 5.2f);

        child child = new child();
        parent parent=new parent();
        child.show();//parent class show method
        child.show(2);//child class method
        child.display();//child class display method

        parent.show();//parent class show method
        parent.display();//parent class display method

    
        parent  p;
        child  c;
        p = parent;//this is valid
        c = child;
        p = child;
        c = parent;//this is not valid

        p.show();
        p.display();
        p.show(2);
        c.show();
        c.display();
        c.show(2);


    }
}