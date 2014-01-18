﻿using System;
using Cqrs.Domain;
using Cqrs.Repositories.Authentication;

namespace Cqrs.Tests.Substitutes
{
	public class TestAggregate : AggregateRoot<ISingleSignOnToken>
	{
		private TestAggregate() { }

		public TestAggregate(Guid id)
		{
			Id = id;
			ApplyChange(new TestAggregateCreated());
		}

		public int DidSomethingCount;

		public void DoSomething()
		{
			ApplyChange(new TestAggregateDidSomething());
		}

		public void DoSomethingElse()
		{
			ApplyChange(new TestAggregateDidSomeethingElse());
		}

		public void Apply(TestAggregateDidSomething e)
		{
			DidSomethingCount++;
		}

	}
}
