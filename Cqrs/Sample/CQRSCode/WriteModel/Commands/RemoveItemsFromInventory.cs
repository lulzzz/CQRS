using System;
using Cqrs.Commands;
using Cqrs.Repositories.Authentication;

namespace CQRSCode.WriteModel.Commands
{
	public class RemoveItemsFromInventory : ICommand<ISingleSignOnToken>
	{
		public readonly int Count;

		public RemoveItemsFromInventory(Guid id, int count, int originalVersion)
		{
			Id = id;
			Count = count;
			ExpectedVersion = originalVersion;
		}

		public Guid Id { get; set; }

		public int ExpectedVersion { get; set; }
	}
}
