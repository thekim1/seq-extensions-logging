using Xunit;

namespace Tests.Support;

/// <summary>
/// Tests in this collection share the process-global <c>SelfLog</c> state
/// (a single static output sink). Running them in parallel causes writes from
/// one test to be observed by another, producing spurious failures, so the
/// collection is serialized.
/// </summary>
[CollectionDefinition("SelfLog", DisableParallelization = true)]
public class SelfLogCollection { }