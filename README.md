# Simple-Audio-Manager
SimpleAudioManager for Unity.

It's best to use it as instance in GameManager.
I prefer to use this in singletons. 

-- [Import] --

You can import this asset in unity via git.
https://github.com/FinallyDeadUwU/Simple-Audio-Manager.git in Package Manager

-- [Functions] --

PlayAudioAtLocation(AudioClip ClipToPlay, float pitch, float volume, Vector3 location) 
-- Creates Object that makes sound at the location you want.

PlayAudio(AudioClip ClipToPlay, float pitch, float volume, bool loop) 
-- Play audio in main audio source. (cannot stack on playing audios)

PlayAudioOnce(AudioClip ClipToPlay, float pitch, float volume) 
-- Play audio once in main audio source. (can stack on playing audios)

StopAllAudios()
-- Stop all audios
