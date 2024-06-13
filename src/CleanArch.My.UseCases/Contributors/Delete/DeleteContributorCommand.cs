using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArch.My.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
