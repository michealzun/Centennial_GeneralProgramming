   M S B A M L   `   `   `  ����H  DCSassignment3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CSassignment3CSassignment3  5   	       CSassignment3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CSassignment3     5   	     � Title$  Naren's Data Entry Form��5   	   $	��350��6)   $	��525��66   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��150* �6   �� 5      $
��375* �6   .+�5   
   �� .��6   Name6   �� 5   
   -   5         ��Name$ TextBoxName��5   "   $��1��6   6"   �� 5   
   $��1��6   .��6   	Residency6(   �� 5   
   $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5      	� -   5         	�Name$ RadioButtonDomestic��5       d� 	IsChecked$
 TrueY�67   .��6H   
Domestic6R   	� 5      .��6   International6)   5      �� 5!   
   $��2��6   .��6   
Semester6'   �� 5"   
   -   5         ��Name$ ComboBoxSemester��5"   0   $��2��6   $��1��6    60   �� 5$   
   $��3��6   .��6   	Courses6&   �� 5%   
   -   5         ��Name$ ListBoxCourses��5%   @   $��3��6   $��1��6   $��3��6/   	 �� SelectionMode$	 Multiple=�6X   6s   �� 5'   
   $��7��6   $��2��6"   $ 
Horizontal=�66   $��	20,0,20,0q�6O   .+�5(      �� -   5        $��Clear��5(   *   $	��200��6:   $��10,5,0,5q�6F   �� 5)      -   5        $��Ok��5)   ,   $	��200��69   $��10,5,0,5q�6E   $��Right=�6W   5*      5+      5,      