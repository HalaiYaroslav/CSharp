   M S B A M L   `   `   `  ����A  =NAudio, Version=1.8.0.0, Culture=neutral, PublicKeyToken=null7(clr-namespace:NAudio.Gui;assembly=NAudio
NAudio.Gui  5   	   F BAudioEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AudioEditorAudioEditor 5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   	   ;"clr-namespace:AudioEditor.ControlsAudioEditor.Controls 5	   	      AudioEditor.MakeRingtone   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =winForms(clr-namespace:NAudio.Gui;assembly=NAudio     5   	   +localclr-namespace:AudioEditor     5   	   Rforms@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   7controls"clr-namespace:AudioEditor.Controls     5	   	   -   5          �Name$  MakeRingtoneWindow��5   i    � Title$ Make Ringtone��6	   $	��600��6   $
��1200��6,    � SizeToContent$ Manual=�69    � 	Resources 5       �� 
TargetType   ButtonStyle �� BasedOn��%0   '��       7   �� 5   
   " ��6   8   6-   5      ��5      �� 5   
    �� ResourceKey$ MetroStyleWindow��6   .��5      � -   5         �Name$ MainGrid��5       � RowDefinitions 5   
   �� 5      �� 5      $
�� 250 �6   �� 5      �� 5      .+�5   
   �� -   5        	 ��Name$	 	BrowseBtn��5      $��Center=�6$   $	��Top=�6A   $��0��6Y   $��Browse Track��6f   6}   �� 5   
   -   5        $	 BackToMainManu��5      $
��Left=�6)   $��Center=�6D   $��0��6_   $��	Main Menu��6l   6�   �� 5    
   
 �� Orientation$
 
Horizontal=�6   $��0��6.   $��Right=�6;   $��Center=�6W   .+�5!      �� -   5        $	 SaveBtn��5!      $
��Save��6&   65   �� 5"      $	��to:��6   $��25(�6"   
����+��$��10q�6H   �� 5#      -   5        $��FileFormatCombBox��5#      $��10q�60   $	��100��6<   $��25(�6H   
����+��.@�5$      �� $
��.ogg��6   �� 5%      $��.flac��6   �� 5&      $
��.mp3��6   5'      5(      7  1System.Windows.Forms.Integration.WindowsFormsHost  5*   
   -   5          Name$ 
WaveHolder��5*      $��1��6/   $��10q�6<   $	��190��6H   $��Stretch=�6U   $��Center=�6s      Child. 5+      %  System.Windows.Forms.PictureBox  -   5        PictureBoxWaveHolder��5+   ?   5,      &   AudioEditor.Controls.RangeSlider  5.   
   -	   5          Name$ RangeSlider��5.       K� ZIndex$ 1��64   $��1��6D   $��Stretch=�6Q   $��Bottom=�6o   $��10q�6�   6�   �� 50   
   $��2��6   $
 
Horizontal=�6"   $��Stretch=�6;   $��Center=�6Z   $��10q�6u   .+�51      �� -
   5         ��Name$ VolumeTxtBlock��51      $��2��60   $
��Left=�6=   $��Bottom=�6X   $��10q�6s   $��Volume:��6   $��25(�6�   �� 52      -   5         ��Name$ VolumeSlider��52       � Maximum$	 0.2Q�6+    � Value$ 0Q�69   $��2��6C   $��Center=�6P   $
��Left=�6k   $	��100��6�   $��10q�6�   6�   �� 53      $��Start Position:��6   $��25(�6/   $��10q�6=   �� 54      -   5         ��Name$# StartResamplingPositionTxtBox��54      $��00:00��6=   $��25(�6J   $��70��6X   $��35��6c   $��10q�6o   �� 55      $��End Position:��6   $��25(�6-   $��10q�6;   �� 56      -   5        $! EndResamplingPositionTxtBox��56      $��00:00��6;   $��25(�6H   $��70��6V   $��35��6a   $��10q�6m   57      �� 59   
   $��3��6   $
 
Horizontal=�6"   .+�5:      �� -   5        $	 PlayBtn��5:      $
��Play��6&   65   �� 5;      -   5        $	 PauseBtn��5;      $��Pause��6'   67   �� 5<      -   5        $	 	RepeatBtn��5<      $��Repeat��6(   69   �� 5=      -   5        $ DurationTxtBlock��5=      $��25(�62   $��00:00��6@   $��Center=�6M   $��10q�6h   �� 5>      -   5        $ PositionTxtBlock��5>      $��25(�62   $��00:00��6@   $��Center=�6M   $��10q�6h   5?      5A      5B      