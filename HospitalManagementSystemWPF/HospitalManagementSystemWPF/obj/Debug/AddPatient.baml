   M S B A M L   `   `   `  ����V  RHospitalManagementSystemWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HospitalManagementSystemWPFHospitalManagementSystemWPF  5   	   ,    &HospitalManagementSystemWPF.AddPatient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:HospitalManagementSystemWPF     5   	     � Title$  
AddPatient��5   	   $	��490��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   .+�5   
   �� $��0��6   $��10q�6%   $��Center=�61   .+�5      �� 
���   �$
��Bold"�5      $��30(�5      .��6   Add New Patient5      �� 5      .��6   Name6   �� 5      -   5        $
��name��5      $��4q�6"   $��2q�6.   6;   �� 5      .��6   Age6   �� 5      -   5        $	��age��5      $��4q�6!   $��2q�6-   6:   �� 5      .��6   Gender6   �� 5      -   5        $��gender��5      .@�5      �� $
��Male��6    �� 
IsSelected . 6.   �� 5      $��Female��6   5      �� 5       .��6   	Address6   �� 5!      -   5        $��address��5!      $��4q�6%   $��2q�61   6>   �� 5"      .��6   Phone6   �� 5#      -   5        $��phone��5#      $��4q�6#   $��2q�6/    �� TextWrapping$ WrapWithOverflow=�6:   6\   �� 5$      -   5        $��5q�5$      $��0q�5%      $��0,5,0,0q�5&      
����d�
�������.��5)   +   Add Patient5+      5,      �� 5-   
   $��1��6   $��Center=�5.      .+�5/      �� $��
0,100,0,32q�50      $��/Images/d5.jpg��51      $	��345��52      $	��200��53      �� 54      $��Get Well Soon��6   $
��20px(�6,   $��Center=�6<   $��40��6Y   �� 55      -   5        $��0q�56      ���#8bc34a$
��50px��59      $��20(�5:      $	��200��5;       J� Opacity$	 0.7Q�5<      
���   �$��5q�5>      $��Back To Dashboard��6!   5?      5@      5A      