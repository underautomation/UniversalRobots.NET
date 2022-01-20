class StatusCode(int):
	OK = 0
	ReadThreadAborted = 1
	DecodageError = 2
	SendCommandInternalError = 3
	SentCommandIsEmpty = 4
	StreamingInterfaceNotConnected = 5
	XmlRpcInternalError = 6
	GlobalVariablesError = 7
	SocketInternalError = 8
	RTDEThreadAborted = 9
	WriteInputsRtdeError = 10
