﻿using CS2_CustomVotes.Shared.Models;

namespace CS2_CustomVotes.Shared;

public interface ICustomVoteApi
{
    public void AddCustomVote(string name, string description, string defaultOption, float timeToVote, Dictionary<string, VoteOption> options, string style);
    public void AddCustomVote(string name, List<string> aliases, string description, string defaultOption, float timeToVote, Dictionary<string, VoteOption> options, string style);
    public void RemoveCustomVote(string name);
}