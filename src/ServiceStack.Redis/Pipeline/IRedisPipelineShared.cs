﻿using System;

namespace ServiceStack.Redis.Pipeline
{
	/// <summary>
	/// Base pipeline interface, shared by typed and non-typed pipelines
	/// </summary>
	public interface IRedisPipelineShared : IDisposable, IRedisQueueCompletableOperation
	{
		void Flush();
		void Replay();
	}
}