namespace ChallengeBugTracking.Tests;
using ChallengeBugTracking;

public class Challenge3Tests
{
    [Test]
    public void ShouldReturnEmptyArrayIfSourceIsEmpty()
    {
        Assert.That(Challenge3.FlattenArray(Array.Empty<Challenge3.Node>()).Length, Is.EqualTo(0));
    }

    [Test]
    public void ShouldFlattenTheExampleArray()
    {
        var array = new Challenge3.Node[] {
            new Challenge3.Leaf { Value = "this" },
            new Challenge3.Branch { Children = new Challenge3.Node[] {
                new Challenge3.Leaf { Value = "is" },
                new Challenge3.Leaf { Value = "an" }
            }},
            new Challenge3.Leaf { Value = "array" }
        };
        Assert.That(Challenge3.FlattenArray(array), Is.EqualTo(new[] { "this", "is", "an", "array" }));
    }

    [Test]
    public void ShouldFlattenDeeplyNestedArray()
    {
        var array = new Challenge3.Node[] {
            new Challenge3.Leaf { Value = "this" },
            new Challenge3.Branch { Children = new Challenge3.Node[] {
                new Challenge3.Leaf { Value = "is" },
                new Challenge3.Leaf { Value = "a" },
                new Challenge3.Branch { Children = new Challenge3.Node[] {
                    new Challenge3.Branch { Children = new Challenge3.Node[] {
                        new Challenge3.Branch { Children = new Challenge3.Node[] {
                            new Challenge3.Leaf { Value = "super" }
                        }},
                        new Challenge3.Leaf { Value = "nested" }
                    }}
                }}
            }},
            new Challenge3.Leaf { Value = "array" }
        };
        Assert.That(Challenge3.FlattenArray(array), Is.EqualTo(new[] { "this", "is", "a", "super", "nested", "array" }));
    }
}