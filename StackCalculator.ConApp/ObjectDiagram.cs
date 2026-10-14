namespace StackCalculator.ConApp
{
    using PlantUML.Logic;
    public static class ObjectDiagram
    {
        private static readonly ObjectDiagramCreator diagramCreator = new("od_Stack.puml");

        public static void Generate(params object[] items)
        {
            foreach (var item in items)
            {
                diagramCreator.CreateToFile(item);
            }
        }
    }
}
