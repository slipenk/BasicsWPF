   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF.Views	WPF.Views  5      /clr-namespace:WPF.ConvertersWPF.Converters  5   	   "    WPF.Views.ManagerUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WPF.Views     5      2	Converterclr-namespace:WPF.Converters     5   	     � 	Resources  5      '  !WPF.Converters.ImagePathConverter   my:ImagePathConverter=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   &	        '         5   
   6'   �� 5   
   "  6   .�5      ��  � ��$ Stretch=�64   �� 5       � ��$ Center=�6;   5      5      .��5   
   � .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  $	��950��6/   $	��Top=�6=   ��6V   ��  �� Path$ Clubs�   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5   "   �� $��30��6(   $��30��63   ��6?   �� *Name+ �� 	Converter# [  5      5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Назва клубу��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� $
 Name� �� Mode$ TwoWay=�  5       $	 
Місто��6)   $
 * 69    6E   �� $
 City�$ TwoWay=�  5!      $3	 -Вартість клубу (млн євро)��6)   $
 * 6M    6Y   �� $ Value�$ TwoWay=�5#      5%      5'      