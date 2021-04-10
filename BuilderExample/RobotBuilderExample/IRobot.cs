namespace RobotBuilderExample
{
    public interface IRobot
    {
        public string Head { get; set; }
        public string Arms { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
    }
}