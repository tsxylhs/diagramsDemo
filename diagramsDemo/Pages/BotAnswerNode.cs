using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace diagramsDemo.Pages
{
    public class BotAnswerNode : NodeModel
    {
        public BotAnswerNode(Blazor.Diagrams.Core.Geometry.Point position = null) : base(position) { }

        public string Answer { get; set; }
    }
}
