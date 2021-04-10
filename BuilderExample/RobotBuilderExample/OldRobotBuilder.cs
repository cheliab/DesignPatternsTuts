using System.Data;

namespace RobotBuilderExample
{
    public class OldRobotBuilder : IRobotBuilder
    {
        private IRobot _robot;

        public OldRobotBuilder()
        {
            _robot = new Robot();
        }
        
        public void BuildHead()
        {
            _robot.Head = "Голова Валли";
        }

        public void BuildTorso()
        {
            _robot.Torso = "Тело Бендера";
        }

        public void BuildArms()
        {
            _robot.Arms = "Руки базуки";
        }

        public void BuildLegs()
        {
            _robot.Legs = "Ноги гусеницы";
        }

        public IRobot GetRobot()
        {
            return _robot;
        }
    }
}