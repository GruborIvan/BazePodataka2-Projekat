   M S B A M L   `   `   `  ����O  KBazeProjekatPokusaj2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:BazeProjekatPokusaj2.CrudWindows BazeProjekatPokusaj2.CrudWindows  5   	   6    0BazeProjekatPokusaj2.CrudWindows.KompanijeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:BazeProjekatPokusaj2.CrudWindows     5   	     � Title$  KompanijeWindow��5   	   $	��450��6!   $	��800��6.   .��5	      � 
�������.+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5      �� .��5      � $	��160��6    � RowDefinitions 5      �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(    � ColumnDefinitions 5      �� 5      $	��220 �6+   �� 5      $	��220 �6+   .+�5      �� $��Naziv kompanije: ��6   $
��Left=�68   $��Center=�6T   $��0��6v   $��0��6�   $��10,0,0,0q�6�    J� RenderTransformOrigin$ 
0.54,0.853&�6�   $	��201��6�   �� 5      -   5         ��Name$ NazivTextBox��5   ;   $��0��6   $��1��6+   $��27��6Q   $��10,13,-89,10q�6^   $	��220��6u   $
��Left=�6�   �� 5      $��Godina osnivanja: ��6   $
��Left=�69   $��Center=�6U   $��0��6w   $��1��6�   $��10,0,0,0q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5      -   5        $ GodOsnivanjaTextBox��5   ;   $��1��6   $��1��6+   $��27��6X   $��10,13,-89,10q�6e   $	��220��6|   $
��Left=�6�   �� 5      $��Lokacija kompanije: ��6   $
��Left=�6;   $��Center=�6W   $��0��6y   $��2��6�   $��10,0,0,0q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5      -   5         ��Name$ LokacijeComboBox��5      $��2��69   $��1��6F   $��10,10,-9,10q�6V    �� SelectedValuePath$ LokID��6�   $
��Left=�6�    �� DisplayMemberPath$
 Grad��6�   $	��220��6�   ��6k   �� *
Lokacije+6�   �� 5!      $��
Direktor: ��6   $
��Left=�61   $��Center=�6M   $��0��6o   $��3��6   $��10,0,0,0q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5"      -   5        $ DirektoriComboBox��5"      $��3��6:   $��1��6G   $��10.2,0,-9.4,0q�6W   $	 OID��6�   $
��Left=�6�   $	 Ime��6�   $	��220��6�   ��6n   �� *	Direktori+6�   �� 5$      -   5        	 ��Name$	 ButtonCancel��5$      $��Cancel��63   $��436,13,-285,7q�6D   $��1��6\   $
��Left=�6l   $��70��6�   $��1��6�   6�   �� 5%      -   5        $	 
ButtonSave��5%      $
��Save��61   $ 0.206,0.858&�6@   $��352,13,-201,7q�6d   $��1��6|   $��1��6�   6�   &   System.Windows.Controls.DataGrid  5'      -   5        
  Name$
 KompanijeList��5'      
����ح�   SelectionMode$ Single=�6M      
IsReadOnly .    AutoGenerateColumns .  $��24,62,-312.4,-240q�6�   $��2��6�   $��3��6�      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      -   5        KID��,  &System.Windows.Controls.DataGridColumn   Header$ Kompanija ID��5)   >      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6T   �� *KID+6l     5*      -	   5        	Naziv��$ Naziv kompanije��5*   @   $	 120 6|    6Y   �� *NazivKompanije+6|     5+      -
   5        GodinaOsnivanja��$ Godina osnivanja��5+   J   $	 110 6�    6d   �� *GodinaOsnivanja+6�     5,      -   5        Lokacija��$ Lokacija kompanije��5,   C   $	 120 6�    6_   �� *Lokacija.Grad+6�     5-      -   5        Direktor��$ Direktor kompanije��5-   C   $	 120 6�    6_   �� *Direktor.Ime+6�   4  .System.Windows.Controls.DataGridTemplateColumn  5.      $ 80 65      CellTemplate 5/   "   �� 50   &   .R�51   *   �� $	 
ButtonEdit��6@   -   5        $
��EDIT��51   1   6T   52   '   54        55      $ 80 65    56   "   �� 57   &   .R�58   *   �� $	 ButtonDelete��6B   -   5        $��DELETE��58   1   6X   59   '   5;      5=      5>      5?      5@      5A      5B      