using System;
using ePOS2_Lib;
using UIKit;

namespace eposPrinterDemo
{
	public class ShowMsg
	{
		public	static void showErrorEpos(Epos2ErrorStatus resultCode, string method)
		{
			string str = string.Format ("{0}\n{1}\n\n{2}\n{3}\n", "methoderr_errcode", getEposErrorText (resultCode), "methoderr_method", method);
		
			show (str);
		}


		public	static	void show(string msg)
		{
			UIAlertView alert = new UIAlertView ("", msg, null, "ok", null);
				

			alert.Show ();
		}

		public	static	string getEposErrorText(Epos2ErrorStatus error)
		{
			string errText = "";
			switch (error) 
			{
			case Epos2ErrorStatus.Success :
				errText = "SUCCESS";
				break;

			case  Epos2ErrorStatus.ErrParam: 
				errText = "ERR_PARAM";
				break;


			case Epos2ErrorStatus.ErrTimeout:
				errText = "ERR_TIMEOUT";
				break;


			case Epos2ErrorStatus.ErrConnect:
				errText = "ERR_CONNECT";
				break;
			case Epos2ErrorStatus.ErrMemory:				
				errText = "ERR_MEMORY";
				break;

			case Epos2ErrorStatus.ErrIllegal:
				errText = "ERR_ILLEGAL";
				break;

			case Epos2ErrorStatus.ErrProcessing:
				errText = "ERR_PROCESSING";
				break;


			case Epos2ErrorStatus.ErrNotFound:
				errText = "ERR_NOT_FOUND";
				break;

			case Epos2ErrorStatus.ErrInUse:
				errText = "ERR_IN_USE";
				break;
			case Epos2ErrorStatus.ErrTypeInvalid:
				errText = "ERR_TYPE_INVALID";
				break;


			case Epos2ErrorStatus.ErrDisconnect:
				errText = "ERR_DISCONNECT";
				break;

			case Epos2ErrorStatus.ErrAlreadyOpened:
				errText = "ERR_ALREADY_OPENED";
				break;
			case Epos2ErrorStatus.ErrAlreadyUsed:
				errText = "ERR_ALREADY_USED";
				break;

			case Epos2ErrorStatus.ErrBoxCountOver:
				errText = @"ERR_BOX_COUNT_OVER";
				break;


			case Epos2ErrorStatus.ErrBoxClientOver:
				errText = @"ERR_BOXT_CLIENT_OVER";
				break;

			case Epos2ErrorStatus.ErrFailure:
				errText = "ERR_FAILURE";
				break;
			default:
				errText = error.ToString();
				break;
			}
			return errText;
		}

	}
}

