   M S B A M L   `   `   `  ����H  DSource Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Source_EditorSource_Editor  5   	   C&clr-namespace:Source_Editor.ViewModelsSource_Editor.ViewModels  63       Source_Editor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Source_Editor     5   	   =
viewmodels&clr-namespace:Source_Editor.ViewModels     63     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   ]� $
��True��6   .+�5      o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $	��New��6   m� 5      $
��Open��6    m� Command 6-   �� *Open+m� 5      $
��Save��6    6-   �� *Save+m� 5      $��Close��6   5      m� 5      $
��View��6   .@�5      m� $��Increase font size��6    6;   �� *IncreaseText+m� 5      $��Decrease font size��6    6;   �� *DecreaseText+5      5      `� 5      $	��Top=�6   .�5      c� .@�5      �� -   5        $��NewFileButton��5       ^� InitialShowDelay$
 5000��6J    � ToolTip$ New File��6q   ��62   �� *New+.��5      �� $��Resources/new.ico��6    $��15��6;   5      5      c� 5      .@�5      �� -   5        $��OpenFileButton��5      $
 5000��6L   $ 	Open File��6s   ��63   �� *Open+.��5      �� $��Resources/open.ico��6    $��15��6<   5       5!      c� 5"      .@�5#      �� -   5        $��SaveFileButton��5#      $
 5000��6L   $ 	Save File��6s   ��63   �� *Save+.��5$      �� $��Resources/save.ico��6    $��15��6<   5%      5&      c� 5'      .@�5(      �� -   5        $��ZoomInButton��5(      ��61   �� *IncreaseText+.��5)      �� $��Resources/zoomin.ico��6    $��15��6>   5*      5+      c� 5,      .@�5-      �� -   5        $��ZoomOutButton��5-      ��62   �� *DecreaseText+.��5.      �� $��Resources/zoomout.ico��6    $��15��6?   5/      50      51      �� 52      .��53      ]� $
��True��6   .+�54      �� -   5        $��LineNumberBox��54      $��25��63   $
��Left=�6>    �� TextWrapping$ NoWrap=�6T    �� TextAlignment$ Right=�6j   $��Modern)�6�    �� 
IsReadOnly$
 True��6�   
�������
�������$��Right=�6�   ��6�   �� *LineNumbers+��6  �� *
FontSize+ �� UpdateSourceTrigger$ PropertyChanged=��� 55      -   5        $��CodeBox��55      $
��Left=�6-   $ NoWrap=�6C   $��Modern)�6Y    �� AcceptsReturn$
 True��6m   	 �� 
AcceptsTab$
	 True��6�   ��6�   �� *CurrentText+$ PropertyChanged=���6�   �� *
FontSize+$ PropertyChanged=�56      57      58      59      5:      