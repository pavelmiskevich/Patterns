namespace TemplateMethod
{
    internal class TeamOfBuilders
    {
        public TeamOfBuilders(Building building)
        {
            building.Build();
        }
    }
}
