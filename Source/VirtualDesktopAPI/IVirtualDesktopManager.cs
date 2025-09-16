// Original Implemation: windows-virtualdesktopindicator by zgdump (https://github.com/zgdump/windows-virtualdesktopindicator)
// Contributors: Dan Krusi (https://github.com/dankrusi), MScholtes (https://github.com/MScholtes), Flaflo (https://github.com/Flaflo)
// License: MIT License (https://github.com/zgdump/windows-virtualdesktopindicator/blob/main/LICENSE)

	namespace WindowsVirtualDesktopHelper.VirtualDesktopAPI {
		public interface IVirtualDesktopManager {
			uint Current();

			int DisplayCount();

			void SwitchForward();

			void SwitchBackward();

			void SwitchToDesktop(int number);

			// Move the currently active/foreground window to the given desktop index (0-based)
			void MoveActiveWindowToDesktop(int number);

			string CurrentDisplayName();

			uint GetVDCount();
		}
	}
