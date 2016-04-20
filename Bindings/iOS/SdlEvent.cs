﻿namespace Urho.iOS
{
	// a copy of SDL_events.h
	public enum SdlEvent
	{
		SDL_FIRSTEVENT = 0,
		/* Application events */
		SDL_QUIT = 0x100,

		SDL_APP_TERMINATING,
		SDL_APP_LOWMEMORY,
		SDL_APP_WILLENTERBACKGROUND,
		SDL_APP_DIDENTERBACKGROUND,
		SDL_APP_WILLENTERFOREGROUND,
		SDL_APP_DIDENTERFOREGROUND,
	}
}