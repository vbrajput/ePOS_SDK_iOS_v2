using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using ExternalAccessory;

namespace ePOS2_Lib
{
	// @interface Epos2PrinterStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2PrinterStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }

		// @property (readonly, getter = getOnline) int online;
		[Export ("online")]
		int Online { [Bind ("getOnline")] get; }

		// @property (readonly, getter = getCoverOpen) int coverOpen;
		[Export ("coverOpen")]
		int CoverOpen { [Bind ("getCoverOpen")] get; }

		// @property (readonly, getter = getPaper) int paper;
		[Export ("paper")]
		int Paper { [Bind ("getPaper")] get; }

		// @property (readonly, getter = getPaperFeed) int paperFeed;
		[Export ("paperFeed")]
		int PaperFeed { [Bind ("getPaperFeed")] get; }

		// @property (readonly, getter = getPanelSwitch) int panelSwitch;
		[Export ("panelSwitch")]
		int PanelSwitch { [Bind ("getPanelSwitch")] get; }

		// @property (readonly, getter = getWaitOnline) int waitOnline;
		[Export ("waitOnline")]
		int WaitOnline { [Bind ("getWaitOnline")] get; }

		// @property (readonly, getter = getDrawer) int drawer;
		[Export ("drawer")]
		int Drawer { [Bind ("getDrawer")] get; }

		// @property (readonly, getter = getErrorStatus) int errorStatus;
		[Export ("errorStatus")]
		int ErrorStatus { [Bind ("getErrorStatus")] get; }

		// @property (readonly, getter = getAutoRecoverError) int autoRecoverError;
		[Export ("autoRecoverError")]
		int AutoRecoverError { [Bind ("getAutoRecoverError")] get; }

		// @property (readonly, getter = getBuzzer) int buzzer;
		[Export ("buzzer")]
		int Buzzer { [Bind ("getBuzzer")] get; }

		// @property (readonly, getter = getAdapter) int adapter;
		[Export ("adapter")]
		int Adapter { [Bind ("getAdapter")] get; }

		// @property (readonly, getter = getBatteryLevel) int batteryLevel;
		[Export ("batteryLevel")]
		int BatteryLevel { [Bind ("getBatteryLevel")] get; }
	}



	// @protocol Epos2ConnectionDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2ConnectionDelegate
	{
		// @required -(void)onConnection:(id)deviceObj eventType:(int)eventType;
		[Abstract]
		[Export ("onConnection:eventType:")]
		void EventType (NSObject deviceObj, int eventType);
	}

	// @protocol Epos2PtrStatusChangeDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2PtrStatusChangeDelegate
	{
		// @required -(void)onPtrStatusChange:(Epos2Printer *)printerObj eventType:(int)eventType;
		[Abstract]
		[Export ("onPtrStatusChange:eventType:")]
		void EventType (Epos2Printer printerObj, int eventType);
	}

	// @protocol Epos2PtrReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2PtrReceiveDelegate
	{
		// @required -(void)onPtrReceive:(Epos2Printer *)printerObj code:(int)code status:(Epos2PrinterStatusInfo *)status printJobId:(NSString *)printJobId;
		[Abstract]
		[Export ("onPtrReceive:code:status:printJobId:")]
		void Code (Epos2Printer printerObj, int code, Epos2PrinterStatusInfo status, string printJobId);
	}

	// @protocol Epos2DispReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2DispReceiveDelegate
	{
		// @required -(void)onDispReceive:(Epos2LineDisplay *)displayObj code:(int)code;
		[Abstract]
		[Export ("onDispReceive:code:")]
		void Code (Epos2LineDisplay displayObj, int code);
	}

	// @protocol Epos2KbdKeyPressDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2KbdKeyPressDelegate
	{
		// @required -(void)onKbdKeyPress:(Epos2Keyboard *)keyboardObj keyCode:(int)keyCode ascii:(NSString *)ascii;
		[Abstract]
		[Export ("onKbdKeyPress:keyCode:ascii:")]
		void KeyCode (Epos2Keyboard keyboardObj, int keyCode, string ascii);
	}

	// @protocol Epos2KbdReadStringDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2KbdReadStringDelegate
	{
		// @required -(void)onKbdReadString:(Epos2Keyboard *)keyboardObj readString:(NSString *)readString prefix:(int)prefix;
		[Abstract]
		[Export ("onKbdReadString:readString:prefix:")]
		void ReadString (Epos2Keyboard keyboardObj, string readString, int prefix);
	}

	// @protocol Epos2ScanDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2ScanDelegate
	{
		// @required -(void)onScanData:(Epos2BarcodeScanner *)scannerObj scanData:(NSString *)scanData;
		[Abstract]
		[Export ("onScanData:scanData:")]
		void ScanData (Epos2BarcodeScanner scannerObj, string scanData);
	}

	// @protocol Epos2SimpleSerialReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2SimpleSerialReceiveDelegate
	{
		// @required -(void)onSimpleSerialReceive:(Epos2SimpleSerial *)serialObj data:(NSData *)data;
		[Abstract]
		[Export ("onSimpleSerialReceive:data:")]
		void Data (Epos2SimpleSerial serialObj, NSData data);
	}

	// @protocol Epos2GetCommHistoryDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2GetCommHistoryDelegate
	{
		// @required -(void)onGetCommHistory:(Epos2CommBox *)commBoxObj code:(int)code historyList:(NSArray *)historyList;
		[Abstract]
		[Export ("onGetCommHistory:code:historyList:")]

		void Code (Epos2CommBox commBoxObj, int code, NSObject[] historyList);
	}

	// @protocol Epos2CommBoxSendMessageDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2CommBoxSendMessageDelegate
	{
		// @required -(void)onCommBoxSendMessage:(Epos2CommBox *)commBoxObj code:(int)code count:(long)count;
		[Abstract]
		[Export ("onCommBoxSendMessage:code:count:")]
		void Code (Epos2CommBox commBoxObj, int code, nint count);
	}

	// @protocol Epos2CommBoxReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2CommBoxReceiveDelegate
	{
		// @required -(void)onCommBoxReceive:(Epos2CommBox *)commBoxObj senderId:(NSString *)senderId receiverId:(NSString *)receiverId message:(NSString *)message;
		[Abstract]
		[Export ("onCommBoxReceive:senderId:receiverId:message:")]
		void SenderId (Epos2CommBox commBoxObj, string senderId, string receiverId, string message);
	}

	// @protocol Epos2DiscoveryDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]

	interface Epos2DiscoveryDelegate
	{
		// @required -(void)onDiscovery:(Epos2DeviceInfo *)deviceInfo;
		[Abstract]
		[Export ("onDiscovery:")]
		void OnDiscovery (Epos2DeviceInfo deviceInfo);
	}

	// @interface Epos2Printer : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2Printer
	{
		// -(id)initWithPrinterSeries:(int)printerSeries lang:(int)lang;
		[Export ("initWithPrinterSeries:lang:")]
		IntPtr Constructor (int printerSeries, int lang);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]

		int Disconnect { get; }

		// -(int)startMonitor;
		[Export ("startMonitor")]

		int StartMonitor { get; }

		// -(int)stopMonitor;
		[Export ("stopMonitor")]

		int StopMonitor { get; }

		// -(Epos2PrinterStatusInfo *)getStatus;
		[Export ("getStatus")]

		Epos2PrinterStatusInfo Status { get; }

		// -(int)sendData:(long)timeout;
		[Export ("sendData:")]
		int SendData (nint timeout);

		// -(int)beginTransaction;
		[Export ("beginTransaction")]

		int BeginTransaction { get; }

		// -(int)endTransaction;
		[Export ("endTransaction")]

		int EndTransaction { get; }

		// -(int)requestPrintJobStatus:(NSString *)printJobId;
		[Export ("requestPrintJobStatus:")]
		int RequestPrintJobStatus (string printJobId);

		// -(int)clearCommandBuffer;
		[Export ("clearCommandBuffer")]

		int ClearCommandBuffer { get; }

		// -(int)addTextAlign:(int)align;
		[Export ("addTextAlign:")]
		int AddTextAlign (int align);

		// -(int)addLineSpace:(long)linespc;
		[Export ("addLineSpace:")]
		int AddLineSpace (nint linespc);

		// -(int)addTextRotate:(int)rotate;
		[Export ("addTextRotate:")]
		int AddTextRotate (int rotate);

		// -(int)addText:(NSString *)data;
		[Export ("addText:")]
		int AddText (string data);

		// -(int)addTextLang:(int)lang;
		[Export ("addTextLang:")]
		int AddTextLang (int lang);

		// -(int)addTextFont:(int)font;
		[Export ("addTextFont:")]
		int AddTextFont (int font);

		// -(int)addTextSmooth:(int)smooth;
		[Export ("addTextSmooth:")]
		int AddTextSmooth (int smooth);

		// -(int)addTextSize:(long)width height:(long)height;
		[Export ("addTextSize:height:")]
		int AddTextSize (nint width, nint height);

		// -(int)addTextStyle:(int)reverse ul:(int)ul em:(int)em color:(int)color;
		[Export ("addTextStyle:ul:em:color:")]
		int AddTextStyle (int reverse, int ul, int em, int color);

		// -(int)addHPosition:(long)x;
		[Export ("addHPosition:")]
		int AddHPosition (nint x);

		// -(int)addFeedUnit:(long)unit;
		[Export ("addFeedUnit:")]
		int AddFeedUnit (nint unit);

		// -(int)addFeedLine:(long)line;
		[Export ("addFeedLine:")]
		int AddFeedLine (nint line);

		// -(int)addImage:(UIImage *)data x:(long)x y:(long)y width:(long)width height:(long)height color:(int)color mode:(int)mode halftone:(int)halftone brightness:(double)brightness compress:(int)compress;
		[Export ("addImage:x:y:width:height:color:mode:halftone:brightness:compress:")]
		int AddImage (UIImage data, nint x, nint y, nint width, nint height, int color, int mode, int halftone, double brightness, int compress);

		// -(int)addLogo:(long)key1 key2:(long)key2;
		[Export ("addLogo:key2:")]
		int AddLogo (nint key1, nint key2);

		// -(int)addBarcode:(NSString *)data type:(int)type hri:(int)hri font:(int)font width:(long)width height:(long)height;
		[Export ("addBarcode:type:hri:font:width:height:")]
		int AddBarcode (string data, int type, int hri, int font, nint width, nint height);

		// -(int)addSymbol:(NSString *)data type:(int)type level:(int)level width:(long)width height:(long)height size:(long)size;
		[Export ("addSymbol:type:level:width:height:size:")]
		int AddSymbol (string data, int type, int level, nint width, nint height, nint size);

		// -(int)addHLine:(long)x1 x2:(long)x2 style:(int)style;
		[Export ("addHLine:x2:style:")]
		int AddHLine (nint x1, nint x2, int style);

		// -(int)addVLineBegin:(long)x style:(int)style lineId:(int *)lineId;
		[Export ("addVLineBegin:style:lineId:")]
		unsafe int AddVLineBegin (nint x, int style, ref int lineId);

		// -(int)addVLineEnd:(int)lineId;
		[Export ("addVLineEnd:")]
		int AddVLineEnd (int lineId);

		// -(int)addPageBegin;
		[Export ("addPageBegin")]

		int AddPageBegin { get; }

		// -(int)addPageEnd;
		[Export ("addPageEnd")]

		int AddPageEnd { get; }

		// -(int)addPageArea:(long)x y:(long)y width:(long)width height:(long)height;
		[Export ("addPageArea:y:width:height:")]
		int AddPageArea (nint x, nint y, nint width, nint height);

		// -(int)addPageDirection:(int)direction;
		[Export ("addPageDirection:")]
		int AddPageDirection (int direction);

		// -(int)addPagePosition:(long)x y:(long)y;
		[Export ("addPagePosition:y:")]
		int AddPagePosition (nint x, nint y);

		// -(int)addPageLine:(long)x1 y1:(long)y1 x2:(long)x2 y2:(long)y2 style:(int)style;
		[Export ("addPageLine:y1:x2:y2:style:")]
		int AddPageLine (nint x1, nint y1, nint x2, nint y2, int style);

		// -(int)addPageRectangle:(long)x1 y1:(long)y1 x2:(long)x2 y2:(long)y2 style:(int)style;
		[Export ("addPageRectangle:y1:x2:y2:style:")]
		int AddPageRectangle (nint x1, nint y1, nint x2, nint y2, int style);

		// -(int)addCut:(int)type;
		[Export ("addCut:")]
		int AddCut (int type);

		// -(int)addPulse:(int)drawer time:(int)time;
		[Export ("addPulse:time:")]
		int AddPulse (int drawer, int time);

		// -(int)addSound:(int)pattern repeat:(long)repeat cycle:(long)cycle;
		[Export ("addSound:repeat:cycle:")]
		int AddSound (int pattern, nint repeat, nint cycle);

		// -(int)addFeedPosition:(int)position;
		[Export ("addFeedPosition:")]
		int AddFeedPosition (int position);

		// -(int)addLayout:(int)type width:(long)width height:(long)height marginTop:(long)marginTop marginBottom:(long)marginBottom offsetCut:(long)offsetCut offsetLabel:(long)offsetLabel;
		[Export ("addLayout:width:height:marginTop:marginBottom:offsetCut:offsetLabel:")]
		int AddLayout (int type, nint width, nint height, nint marginTop, nint marginBottom, nint offsetCut, nint offsetLabel);

		// -(int)addCommand:(NSData *)data;
		[Export ("addCommand:")]
		int AddCommand (NSData data);

		// -(int)forceRecover:(long)timeout;
		[Export ("forceRecover:")]
		int ForceRecover (nint timeout);

		// -(int)forcePulse:(int)drawer pulseTime:(int)time timeout:(long)timeout;
		[Export ("forcePulse:pulseTime:timeout:")]
		int ForcePulse (int drawer, int time, nint timeout);

		// -(int)forceStopSound:(long)timeout;
		[Export ("forceStopSound:")]
		int ForceStopSound (nint timeout);

		// -(int)forceCommand:(NSData *)data timeout:(long)timeout;
		[Export ("forceCommand:timeout:")]
		int ForceCommand (NSData data, nint timeout);

		// -(int)forceReset:(long)timeout;
		[Export ("forceReset:")]
		int ForceReset (nint timeout);

		// -(void)setStatusChangeEventDelegate:(id<Epos2PtrStatusChangeDelegate>)delegate;
		[Export ("setStatusChangeEventDelegate:")]
		void SetStatusChangeEventDelegate (Epos2PtrStatusChangeDelegate @delegate);

		// -(void)setReceiveEventDelegate:(id<Epos2PtrReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate (Epos2PtrReceiveDelegate @delegate);

		// -(int)setInterval:(long)interval;
		[Export ("setInterval:")]
		int SetInterval (nint interval);

		// -(long)getInterval;
		[Export ("getInterval")]

		nint Interval { get; }

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate (Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]

		string Admin { get; }

		// -(NSString *)getLocation;
		[Export ("getLocation")]

		string Location { get; }
	}

	// @interface Epos2DisplayStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2DisplayStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2LineDisplay : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2LineDisplay
	{
		// -(id)initWithDisplayModel:(int)displayModel;
		[Export ("initWithDisplayModel:")]
		IntPtr Constructor (int displayModel);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]

		int Disconnect { get; }

		// -(Epos2DisplayStatusInfo *)getStatus;
		[Export ("getStatus")]

		Epos2DisplayStatusInfo Status { get; }

		// -(int)sendData;
		[Export ("sendData")]

		int SendData { get; }

		// -(int)clearCommandBuffer;
		[Export ("clearCommandBuffer")]

		int ClearCommandBuffer { get; }

		// -(int)addInitialize;
		[Export ("addInitialize")]

		int AddInitialize { get; }

		// -(int)addCreateWindow:(long)number x:(long)x y:(long)y width:(long)width height:(long)height scrollMode:(int)scrollMode;
		[Export ("addCreateWindow:x:y:width:height:scrollMode:")]
		int AddCreateWindow (nint number, nint x, nint y, nint width, nint height, int scrollMode);

		// -(int)addDestroyWindow:(long)number;
		[Export ("addDestroyWindow:")]
		int AddDestroyWindow (nint number);

		// -(int)addSetCurrentWindow:(long)number;
		[Export ("addSetCurrentWindow:")]
		int AddSetCurrentWindow (nint number);

		// -(int)addClearCurrentWindow;
		[Export ("addClearCurrentWindow")]

		int AddClearCurrentWindow { get; }

		// -(int)addSetCursorPosition:(long)x y:(long)y;
		[Export ("addSetCursorPosition:y:")]
		int AddSetCursorPosition (nint x, nint y);

		// -(int)addMoveCursorPosition:(int)position;
		[Export ("addMoveCursorPosition:")]
		int AddMoveCursorPosition (int position);

		// -(int)addSetCursorType:(int)type;
		[Export ("addSetCursorType:")]
		int AddSetCursorType (int type);

		// -(int)addText:(NSString *)data;
		[Export ("addText:")]
		int AddText (string data);

		// -(int)addText:(NSString *)data lang:(int)lang;
		[Export ("addText:lang:")]
		int AddText (string data, int lang);

		// -(int)addText:(NSString *)data x:(long)x y:(long)y;
		[Export ("addText:x:y:")]
		int AddText (string data, nint x, nint y);

		// -(int)addText:(NSString *)data x:(long)x y:(long)y lang:(int)lang;
		[Export ("addText:x:y:lang:")]
		int AddText (string data, nint x, nint y, int lang);

		// -(int)addReverseText:(NSString *)data;
		[Export ("addReverseText:")]
		int AddReverseText (string data);

		// -(int)addReverseText:(NSString *)data lang:(int)lang;
		[Export ("addReverseText:lang:")]
		int AddReverseText (string data, int lang);

		// -(int)addReverseText:(NSString *)data x:(long)x y:(long)y;
		[Export ("addReverseText:x:y:")]
		int AddReverseText (string data, nint x, nint y);

		// -(int)addReverseText:(NSString *)data x:(long)x y:(long)y lang:(int)lang;
		[Export ("addReverseText:x:y:lang:")]
		int AddReverseText (string data, nint x, nint y, int lang);

		// -(int)addMarqueeText:(NSString *)data format:(int)format unitWait:(long)unitWait repeatWait:(long)repeatWait repeatCount:(long)repeatCount lang:(int)lang;
		[Export ("addMarqueeText:format:unitWait:repeatWait:repeatCount:lang:")]
		int AddMarqueeText (string data, int format, nint unitWait, nint repeatWait, nint repeatCount, int lang);

		// -(int)addSetBlink:(long)interval;
		[Export ("addSetBlink:")]
		int AddSetBlink (nint interval);

		// -(int)addSetBrightness:(int)brightness;
		[Export ("addSetBrightness:")]
		int AddSetBrightness (int brightness);

		// -(int)addShowClock;
		[Export ("addShowClock")]

		int AddShowClock { get; }

		// -(int)addCommand:(NSData *)data;
		[Export ("addCommand:")]
		int AddCommand (NSData data);

		// -(void)setReceiveEventDelegate:(id<Epos2DispReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate (Epos2DispReceiveDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate (Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]

		string Admin { get; }

		// -(NSString *)getLocation;
		[Export ("getLocation")]

		string Location { get; }
	}

	// @interface Epos2KeyboardStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2KeyboardStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2Keyboard : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2Keyboard
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]

		int Disconnect { get; }

		// -(Epos2KeyboardStatusInfo *)getStatus;
		[Export ("getStatus")]

		Epos2KeyboardStatusInfo Status { get; }

		// -(int)setPrefix:(NSData *)data;
		[Export ("setPrefix:")]
		int SetPrefix (NSData data);

		// -(NSData *)getPrefix;
		[Export ("getPrefix")]

		NSData Prefix { get; }

		// -(void)setKeyPressEventDelegate:(id<Epos2KbdKeyPressDelegate>)delegate;
		[Export ("setKeyPressEventDelegate:")]
		void SetKeyPressEventDelegate (Epos2KbdKeyPressDelegate @delegate);

		// -(void)setReadStringEventDelegate:(id<Epos2KbdReadStringDelegate>)delegate;
		[Export ("setReadStringEventDelegate:")]
		void SetReadStringEventDelegate (Epos2KbdReadStringDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate (Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]

		string Admin { get; }

		// -(NSString *)getLocation;
		[Export ("getLocation")]

		string Location { get; }
	}

	// @interface Epos2ScannerStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2ScannerStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2BarcodeScanner : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2BarcodeScanner
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]

		int Disconnect { get; }

		// -(Epos2ScannerStatusInfo *)getStatus;
		[Export ("getStatus")]

		Epos2ScannerStatusInfo Status { get; }

		// -(void)setScanEventDelegate:(id<Epos2ScanDelegate>)delegate;
		[Export ("setScanEventDelegate:")]
		void SetScanEventDelegate (Epos2ScanDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate (Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]

		string Admin { get; }

		// -(NSString *)getLocation;
		[Export ("getLocation")]

		string Location { get; }
	}

	// @interface Epos2SimpleSerialStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2SimpleSerialStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2SimpleSerial : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2SimpleSerial
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]

		int Disconnect { get; }

		// -(Epos2SimpleSerialStatusInfo *)getStatus;
		[Export ("getStatus")]

		Epos2SimpleSerialStatusInfo Status { get; }

		// -(int)sendCommand:(NSData *)data;
		[Export ("sendCommand:")]
		int SendCommand (NSData data);

		// -(void)setReceiveEventDelegate:(id<Epos2SimpleSerialReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate (Epos2SimpleSerialReceiveDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate (Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]

		string Admin { get; }

		// -(NSString *)getLocation;
		[Export ("getLocation")]

		string Location { get; }
	}

	// @interface Epos2CommBoxStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CommBoxStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2CommBox : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CommBox
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout myId:(NSString *)myId;
		[Export ("connect:timeout:myId:")]
		int Connect (string target, nint timeout, string myId);

		// -(int)disconnect;
		[Export ("disconnect")]

		int Disconnect { get; }

		// -(Epos2CommBoxStatusInfo *)getStatus;
		[Export ("getStatus")]

		Epos2CommBoxStatusInfo Status { get; }

		// -(int)getCommHistory:(id<Epos2GetCommHistoryDelegate>)delegate;
		[Export ("getCommHistory:")]
		int GetCommHistory (Epos2GetCommHistoryDelegate @delegate);

		// -(int)sendMessage:(NSString *)message targetId:(NSString *)targetId delegate:(id<Epos2CommBoxSendMessageDelegate>)delegate;
		[Export ("sendMessage:targetId:delegate:")]
		int SendMessage (string message, string targetId, Epos2CommBoxSendMessageDelegate @delegate);

		// -(void)setReceiveEventDelegate:(id<Epos2CommBoxReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate (Epos2CommBoxReceiveDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate (Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]

		string Admin { get; }

		// -(NSString *)getLocation;
		[Export ("getLocation")]

		string Location { get; }
	}

	// @interface Epos2FilterOption : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2FilterOption
	{
		// @property (getter = getPortType, nonatomic, setter = setPortType:) int portType;
		[Export ("portType")]
		int PortType { [Bind ("getPortType")] get; [Bind ("setPortType:")] set; }

		// @property (getter = getBroadcast, copy, nonatomic, setter = setBroadcast:) NSString * broadcast;
		[Export ("broadcast")]
		string Broadcast { [Bind ("getBroadcast")] get; [Bind ("setBroadcast:")] set; }

		// @property (getter = getDeviceModel, nonatomic, setter = setDeviceModel:) int deviceModel;
		[Export ("deviceModel")]
		int DeviceModel { [Bind ("getDeviceModel")] get; [Bind ("setDeviceModel:")] set; }

		// @property (getter = getDeviceType, nonatomic, setter = setDeviceType:) int deviceType;
		[Export ("deviceType")]
		int DeviceType { [Bind ("getDeviceType")] get; [Bind ("setDeviceType:")] set; }
	}

	// @interface Epos2DeviceInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2DeviceInfo
	{
		// @property (readonly, getter = getDeviceType, nonatomic) int deviceType;
		[Export ("deviceType")]
		int DeviceType { [Bind ("getDeviceType")] get; }

		// @property (readonly, getter = getTarget, copy, nonatomic) NSString * target;
		[Export ("target")]
		string Target { [Bind ("getTarget")] get; }

		// @property (readonly, getter = getDeviceName, copy, nonatomic) NSString * deviceName;
		[Export ("deviceName")]
		string DeviceName { [Bind ("getDeviceName")] get; }

		// @property (readonly, getter = getIpAddress, copy, nonatomic) NSString * ipAddress;
		[Export ("ipAddress")]
		string IpAddress { [Bind ("getIpAddress")] get; }

		// @property (readonly, getter = getMacAddress, copy, nonatomic) NSString * macAddress;
		[Export ("macAddress")]
		string MacAddress { [Bind ("getMacAddress")] get; }

		// @property (readonly, getter = getBdAddress, copy, nonatomic) NSString * bdAddress;
		[Export ("bdAddress")]
		string BdAddress { [Bind ("getBdAddress")] get; }
	}

	// @interface Epos2Discovery : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2Discovery
	{
		// +(int)start:(Epos2FilterOption *)filterOption delegate:(id<Epos2DiscoveryDelegate>)delegate;
		[Static]
		[Export ("start:delegate:")]
		int Start (Epos2FilterOption filterOption, Epos2DiscoveryDelegate @delegate);

		// +(int)stop;
		[Static]
		[Export ("stop")]

		int Stop { get; }
	}

	// @interface Epos2Log : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2Log
	{
		// +(int)setLogSettings:(int)period output:(int)output ipAddress:(NSString *)ipAddress port:(int)port logSize:(int)logSize logLevel:(int)logLevel;
		[Static]
		[Export ("setLogSettings:output:ipAddress:port:logSize:logLevel:")]
		int SetLogSettings (int period, int output, string ipAddress, int port, int logSize, int logLevel);
	}

	// @interface Epos2BluetoothConnection : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2BluetoothConnection
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connectDevice:(NSMutableString *)target;
		[Export ("connectDevice:")]
		int ConnectDevice (NSMutableString target);

		// -(int)disconnectDevice:(NSString *)target;
		[Export ("disconnectDevice:")]
		int DisconnectDevice (string target);
	}

}

