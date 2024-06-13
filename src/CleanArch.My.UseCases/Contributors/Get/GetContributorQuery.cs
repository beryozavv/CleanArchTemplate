using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArch.My.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
