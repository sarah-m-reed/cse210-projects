public class BadgeManager
{
    private List<string> _earnedBadges = new List<string>();

    public void EvaluateBadges(int score, List<Goal> goals)
    {
        if (score >= 1000 && !_earnedBadges.Contains("Level 1 Achiever"))
        {
            AwardBadge("Level 1 Achiever");
        }

        int completedGoals = goals.Count(g => g.IsComplete());
        if (completedGoals >= 3 && !_earnedBadges.Contains("Goal Crusher"))
        {
            AwardBadge("Goal Crusher");
        }

        if (goals.OfType<ChecklistGoal>().Any(cg => cg.IsComplete()) && !_earnedBadges.Contains("Checklist Champion"))
        {
            AwardBadge("Checklist Champion");
        }
    }
    private void AwardBadge(string badge)
    {
        _earnedBadges.Add(badge);
        Console.WriteLine($"\n You earned a badge: {badge}!");
    }
    public void SaveBadges(StreamWriter writer)
    {
        foreach (string badge in _earnedBadges)
        {
            writer.WriteLine($"Badge|{badge}");
        }
    }
    public void LoadBadge(string badgeName)
    {
        if (!_earnedBadges.Contains(badgeName))
        {
            _earnedBadges.Add(badgeName);
        }
    }
    public void DisplayBadges()
    {
        if (_earnedBadges.Count == 0)
        {
            Console.WriteLine("You haven't earned any badges yet.");
        }
        else
        {
            Console.WriteLine("Earned Badges:");
            foreach (string badge in _earnedBadges)
            {
                Console.WriteLine($" - {badge}");
            }
        }
    }
}