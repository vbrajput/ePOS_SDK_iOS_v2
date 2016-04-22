using System;

namespace ePOS2_Lib
{
	public enum Epos2ErrorStatus
	{
		Success = 0,
		ErrParam,
		ErrConnect,
		ErrTimeout,
		ErrMemory,
		ErrIllegal,
		ErrProcessing,
		ErrNotFound,
		ErrInUse,
		ErrTypeInvalid,
		ErrDisconnect,
		ErrAlreadyOpened,
		ErrAlreadyUsed,
		ErrBoxCountOver,
		ErrBoxClientOver,
		ErrUnsupported,
		ErrFailure = 255
	}

	public enum Epos2CallbackCode
	{
		Success = 0,
		ErrTimeout,
		ErrNotFound,
		ErrAutorecover,
		ErrCoverOpen,
		ErrCutter,
		ErrMechanical,
		ErrEmpty,
		ErrUnrecoverable,
		ErrSystem,
		ErrPort,
		ErrInvalidWindow,
		ErrJobNotFound,
		Printing,
		ErrSpooler,
		ErrBatteryLow,
		ErrFailure = 255
	}

	public enum Epos2PrinterSeries
	{
		M10 = 0,
		M30,
		P20,
		P60,
		P60ii,
		P80,
		T20,
		T70,
		T81,
		T82,
		T83,
		T88,
		T90,
		T90kp,
		U220,
		U330,
		L90,
		H6000
	}

	public enum Epos2DisplayModel
	{
		Epos2DmD30 = 0,
		Epos2DmD110
	}

	public enum Epos2ModelLang
	{
		Ank = 0,
		Japanese,
		Chinese,
		Taiwan,
		Korean,
		Thai,
		Southasia
	}

	public enum Epos2DeviceModel
	{
		Epos2ModelAll = 0
	}

	public enum Epos2PortType
	{
		All = 0,
		Tcp,
		Bluetooth
	}

	public enum Epos2StatusPaper
	{
		Ok = 0,
		NearEnd,
		Empty
	}

	public enum Epos2PanelSwitch
	{
		Ff = 0,
		N
	}

	public enum Epos2StatusDrawer
	{
		High = 0,
		Low
	}

	public enum Epos2PrinterError
	{
		NoErr = 0,
		MechanicalErr,
		AutocutterErr,
		UnrecoverErr,
		AutorecoverErr
	}

	public enum Epos2AutoRecoverError
	{
		HeadOverheat = 0,
		MotorOverheat,
		BatteryOverheat,
		WrongPaper
	}

	public enum Epos2BatteryLevel
	{
		Epos2BatteryLevel0 = 0,
		Epos2BatteryLevel1,
		Epos2BatteryLevel2,
		Epos2BatteryLevel3,
		Epos2BatteryLevel4,
		Epos2BatteryLevel5,
		Epos2BatteryLevel6
	}

	public enum Epos2StatusEvent
	{
		Online = 0,
		Offline,
		PowerOff,
		CoverClose,
		CoverOpen,
		PaperOk,
		PaperNearEnd,
		PaperEmpty,
		DrawerHigh,
		DrawerLow,
		BatteryEnough,
		BatteryEmpty
	}

	public enum Epos2ConnectionEvent
	{
		Reconnecting = 0,
		Reconnect,
		Disconnect
	}

	public enum Epos2DeviceType
	{
		All = 0,
		Printer,
		Display,
		Keyboard,
		Scanner,
		Serial
	}

	public enum Epos2Align
	{
		Left = 0,
		Center,
		Right
	}

	public enum Epos2Lang
	{
		En = 0,
		Ja,
		ZhCn,
		ZhTw,
		Ko,
		Th,
		Vi
	}

	public enum Epos2Font
	{
		A = 0,
		B,
		C,
		D,
		E
	}

	public enum Epos2Color
	{
		None = 0,
		Epos2Color1,
		Epos2Color2,
		Epos2Color3,
		Epos2Color4
	}

	public enum Epos2Mode
	{
		Mono = 0,
		Gray16
	}

	public enum Epos2Halftone
	{
		Dither = 0,
		ErrorDiffusion,
		Threshold
	}

	public enum Epos2Compress
	{
		Deflate = 0,
		None,
		Auto
	}

	public enum Epos2Barcode
	{
		UpcA = 0,
		UpcE,
		Ean13,
		Jan13,
		Ean8,
		Jan8,
		Code39,
		Itf,
		Codabar,
		Code93,
		Code128,
		Gs1128,
		Gs1DatabarOmnidirectional,
		Gs1DatabarTruncated,
		Gs1DatabarLimited,
		Gs1DatabarExpanded
	}

	public enum Epos2Hri
	{
		None = 0,
		Above,
		Below,
		Both
	}

	public enum Epos2Symbol
	{
		Pdf417Standard = 0,
		Pdf417Truncated,
		QrcodeModel1,
		QrcodeModel2,
		QrcodeMicro,
		MaxicodeMode2,
		MaxicodeMode3,
		MaxicodeMode4,
		MaxicodeMode5,
		MaxicodeMode6,
		Gs1DatabarStacked,
		Gs1DatabarStackedOmnidirectional,
		Gs1DatabarExpandedStacked,
		AzteccodeFullrange,
		AzteccodeCompact,
		DatamatrixSquare,
		DatamatrixRectangle8,
		DatamatrixRectangle12,
		DatamatrixRectangle16
	}

	public enum Epos2Level
	{
		Epos2Level0 = 0,
		Epos2Level1,
		Epos2Level2,
		Epos2Level3,
		Epos2Level4,
		Epos2Level5,
		Epos2Level6,
		Epos2Level7,
		Epos2Level8,
		L,
		M,
		Q,
		H
	}

	public enum Epos2Line
	{
		Thin = 0,
		Medium,
		Thick,
		ThinDouble,
		MediumDouble,
		ThickDouble
	}

	public enum Epos2Direction
	{
		LeftToRight = 0,
		BottomToTop,
		RightToLeft,
		TopToBottom
	}

	public enum Epos2Cut
	{
		Feed = 0,
		NoFeed,
		Reserve
	}

	public enum Epos2Drawer
	{
		Epos2Drawer2pin = 0,
		Epos2Drawer5pin
	}

	public enum Epos2Pulse
	{
		Epos2Pulse100 = 0,
		Epos2Pulse200,
		Epos2Pulse300,
		Epos2Pulse400,
		Epos2Pulse500
	}

	public enum Epos2Pattern
	{
		None = 0,
		A,
		B,
		C,
		D,
		E,
		Error,
		PaperEmpty,
		Epos2Pattern1,
		Epos2Pattern2,
		Epos2Pattern3,
		Epos2Pattern4,
		Epos2Pattern5,
		Epos2Pattern6,
		Epos2Pattern7,
		Epos2Pattern8,
		Epos2Pattern9,
		Epos2Pattern10
	}

	public enum Epos2FeedPosition
	{
		Peeling = 0,
		Cutting,
		CurrentTof,
		NextTof
	}

	public enum Epos2Layout
	{
		Receipt = 0,
		ReceiptBm,
		Label,
		LabelBm
	}

	public enum Epos2Scroll
	{
		Overwrite = 0,
		Vertical,
		Horizontal
	}

	public enum Epos2Format
	{
		Walk = 0,
		Place
	}

	public enum Epos2Brightness
	{
		Epos2Brightness20 = 0,
		Epos2Brightness40,
		Epos2Brightness60,
		Epos2Brightness100
	}

	public enum Epos2CursorPosition
	{
		TopLeft = 0,
		TopRight,
		BottomLeft,
		BottomRight
	}

	public enum Epos2CursorType
	{
		None = 0,
		Underline
	}

	public enum Epos2LogPeriod
	{
		Temporary = 0,
		Permanent
	}

	public enum Epos2LogOutput
	{
		Disable = 0,
		Storage,
		Tcp
	}

	public enum Epos2LogLevel
	{
		Epos2LoglevelLow = 0
	}

	public enum Epos2BtConnection
	{
		Success = 0,
		ErrParam,
		ErrUnsupported,
		ErrCancel,
		ErrAlreadyConnect,
		ErrIllegalDevice,
		ErrFailure = 255
	}

}

