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
        // TODO: ISSUE #4242 : Our customer reported that this method doesn't work in the case of deeply nested arrays
        // I added the test case to the test file, but I'm not sure how to fix it. Can you help?
        var result = new List<string>();
        foreach(var node in nodes) {
            if(node is Branch b) {
                result.AddRange(b.Children.Cast<Leaf>().Select(l => l.Value));
            } else if(node is Leaf l) {
                result.Add(l.Value);
            }
        }

        return result.ToArray();
    }
}