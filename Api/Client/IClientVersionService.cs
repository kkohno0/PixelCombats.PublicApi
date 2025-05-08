﻿namespace PixelCombats.Api.Client
{
	/// <summary>
	/// сервис версии игрового клиента
	/// </summary>
	public interfac IClientVersionService
	{
		/// <summary>
		/// текущая версия клиента игры
		/// </summary>
		uint ClientVersion { get; }
	}
}
