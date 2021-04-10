namespace RobotBuilderExample
{
    public interface IRobotBuilder
    {
        public void BuildHead();
        public void BuildTorso();
        public void BuildArms();
        public void BuildLegs();

        public IRobot GetRobot();

    }
}