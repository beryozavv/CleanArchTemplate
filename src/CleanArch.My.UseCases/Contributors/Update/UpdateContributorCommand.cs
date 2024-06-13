using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArch.My.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
