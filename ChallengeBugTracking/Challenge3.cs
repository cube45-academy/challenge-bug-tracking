namespace ChallengeBugTracking;

public class Challenge3 {

    public abstract class Node {
    }

    public class Branch : Node {
        public required Node[] Children { get; init; }
    }

    public class Leaf : Node {
        public required string Value { get; init; }
    }

    /// <summary>
    /// Flattens an array into a single array.
    /// For example, FlattenArray(['this', ['is', 'an'], 'array']) should return ['this', 'is', 'an', 'array']
    /// </summary>
    /// <param name="array">The array to flatten</param>
    public static string[] FlattenArray(IEnumerable<Node> nodes) {
        List<string> output = new();
        foreach(var node in nodes) {
            if(node is Branch b) {
                output.AddRange(FlattenArray(b.Children));
            } else if(node is Leaf l) {
                output.Add(l.Value);
            }
        }
        return output.ToArray();
    }
}