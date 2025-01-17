﻿using CS2_CustomVotes.Models;
using CS2_CustomVotes.Shared;
using CS2_CustomVotes.Shared.Models;

namespace CS2_CustomVotes.Services;

public class CustomVoteApi : ICustomVoteApi
{
    private readonly IVoteManager _voteManager;

    public CustomVoteApi(IVoteManager voteManager)
    {
        _voteManager = voteManager;
    }

    public void AddCustomVote(string name, string description, string defaultOption, float timeToVote, Dictionary<string, VoteOption> options, string style)
    {
        _voteManager.AddVote(name, new List<string>(), description, defaultOption, timeToVote, options, style);
    }

    public void AddCustomVote(string name, List<string> aliases, string description, string defaultOption, float timeToVote,
        Dictionary<string, VoteOption> options, string style)
    {
        _voteManager.AddVote(name, aliases, description, defaultOption, timeToVote, options, style);
    }

    public void RemoveCustomVote(string name)
    {
        _voteManager.RemoveVote(name);
    }
}