   M S B A M L   `   `   `  ����O  KBazeProjekatPokusaj2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:BazeProjekatPokusaj2.CrudWindows BazeProjekatPokusaj2.CrudWindows  5   	   6    0BazeProjekatPokusaj2.CrudWindows.DirektoriWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:BazeProjekatPokusaj2.CrudWindows     5   	     � Title$  DirektoriWindow��5   	   $	��550��6!   $	��820��6.   .��5	      � 
�������.+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5      �� .��5      � $	��200��6   $��26,30,17,30q�6$    � RowDefinitions 5      �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(    � ColumnDefinitions 5      �� 5      $	��220 �6+   �� 5      $	��242 �6+   �� 5      $��18 �6+   .+�5      �� $��JMBG Direktora: ��6   $
��Left=�67   $��Center=�6S   $��0��6u   $��0��6�   $��10,0,0,0q�6�    J� RenderTransformOrigin$ 
0.54,0.853&�6�   $	��160��6�   �� 5      -   5         ��Name$ JMBGTextBox��5   ;   $��0��6   $��1��6+   $��
10,10,0,10q�6Q   $	��210��6f   $
��Left=�6r   �� 5      $��Prezime direktora: ��6   $
��Left=�6:   $��Center=�6V   $��0��6x   $��2��6�   $ 
0.54,0.853&�6�   $	��160��6�   $��	10,5,0,35q�6�   $��2��6�   �� 5      -   5        $ 
ImeTextBox��5   ;   $��1��6   $��1��6+   $��
11,10,0,10q�6P   $	��210��6e   $
��Left=�6q   �� 5      $��Radni staz direktora: ��6   $
��Left=�6=   $��Center=�6Y   $��0��6{   $��3��6�   $ 
0.54,0.853&�6�   $	��160��6�   $��10,0,0,0q�6�   �� 5       -   5        $ PrezimeTextBox��5    ;   $��2��6   $��1��6+   $��
11,10,0,10q�6T   $	��210��6i   $
��Left=�6u   �� 5"      $��Ime direktora: ��6   $
��Left=�66   $��Center=�6R   $��0��6t   $��1��6�   $��	10,10,0,7q�6�   $ 
0.54,0.853&�6�   $	��160��6�   �� 5#      -   5        $ RadniStazTextBox��5#   ;   $��3��6   $��1��6+   $��
11,10,0,10q�6V   $	��210��6k   $
��Left=�6w   �� 5%      $��Ugovor: ��6   $
��Left=�6/   $��Center=�6K   $��0��6m   $��4��6}   $��	10,10,0,7q�6�   $ 
0.54,0.853&�6�   $	��160��6�   �� 5&      -   5         ��Name$ UgovorComboBox��5&      $��4��67   $��1��6D   $��
10.2,1,0,0q�6T    �� SelectedValuePath$	 UID��6�   $
��Left=�6�    �� DisplayMemberPath$ TrajanjeUgovora��6�   $	��220��6�   ��6h   �� *	Ugovori+6�   �� 5(      -   5        	 ��Name$	 ButtonCancel��5(      $��Cancel��63   $��158.8,10,-210.4,0q�6D   $��2��6`   $
��Left=�6p   $��70��6�   $��1��6�   6�   �� 5)      -   5        $	 
ButtonSave��5)      $
��Save��61   $ 0.206,0.858&�6@   $��68,8,-119,2q�6d   $��2��6z   $��1��6�   6�   &   System.Windows.Controls.DataGrid  5+      -   5        
  Name$
 DirektoriList��5+      
����ح�   SelectionMode$ Single=�6M      
IsReadOnly .    AutoGenerateColumns .  $��-25,64,-270.4,-260q�6�   $��3��6�   $��4��6�      Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      -	   5        JMBGDirektora��,  &System.Windows.Controls.DataGridColumn   Header$ JMBG Direktora��5-   H      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6`   �� *JMBG+6y     5.      -
   5        Ime��$ Ime Direktora��5.   >   $	 120 6m    6U   �� *Ime+6m     5/      -   5        Prezime��$ Prezime Direktora��5/   B   $	 120 6y    6]   �� *	Prezime+6y     50      -   5        	RadniStaz��$ Radni staz direktora��50   D   $	 120 6�    6b   �� *	RadniStaz+6�     51      -   5        	TrajanjeU��$ Trajanje ugovora��51   D   $	 120 6�    6^   �� *Ugovor.TrajanjeUgovora+6�   4  .System.Windows.Controls.DataGridTemplateColumn  52      $ 80 65      CellTemplate 53   "   �� 54   &   .R�55   *   �� $	 
ButtonEdit��6@   -   5        $
��EDIT��55   1   6T   56   '   58        59      $ 80 65    5:   "   �� 5;   &   .R�5<   *   �� $	 ButtonDelete��6B   -   5        $��DELETE��5<   1   6X   5=   '   5?      5A      5B      5C      5D      5E      5F      