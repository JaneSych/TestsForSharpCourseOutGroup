namespace Lab2.HomeWorks
{
    public class ClassTest1 : AClassTest, ClassInterface
    {
        public ClassTest1()
        {

        }
  
        public string PringFromInterface()
        {
            return "It is ClassTest1Interface";
        }

        public override string Print()
        {
            return "It is ClassTest1";
        }
    }
}