namespace RobotBuilderExample
{
    public class RobotEngineer
    {
        private IRobotBuilder _robotBuilder;

        public RobotEngineer(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }

        public IRobot GetRobot()
        {
            return _robotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            _robotBuilder.BuildHead();
            _robotBuilder.BuildTorso();
            _robotBuilder.BuildArms();
            _robotBuilder.BuildLegs();
        }

    }
}