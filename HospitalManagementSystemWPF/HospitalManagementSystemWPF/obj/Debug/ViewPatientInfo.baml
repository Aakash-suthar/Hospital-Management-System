   M S B A M L   `   `   `  ����V  RHospitalManagementSystemWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HospitalManagementSystemWPFHospitalManagementSystemWPF  5   	   1    +HospitalManagementSystemWPF.ViewPatientInfo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:HospitalManagementSystemWPF     5   	     � Title$  ViewPatientInfo��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��1��6   .+�5      �� $��0 20 0 0q�6   .��6&   Enter patient id68   �� 5      -   5        $��	patientid��5      6)   �� 5      -   5        
���   �$��300px��5       J� Opacity$	 0.6Q�5      
�������$��5q�5      $��5q�5      .��6    Search6(   �� 5      -   5        
���   �$	 0.6Q�5      
�������$��300px��5      $��5q�5       $
��48,5q�5!      $��	Dashboard��6#   5"      �� 5#   
   $��0��6   $��5,15,5,0q�6%   $��Center=�67   .+�5$      �� $
��30px(�6   $��	ExtraBold"�6$   
���   �$	 0.6Q�6N   
�������.��6o   View Patient Details6�   �� 5%      .��6   
Patient Id6    �� 5&      -   5        $��patient_id_textbox��5&      62   �� 5'      .��6   Patient Name6"   �� 5(      -   5        $��patient_name_textbox��5(      64   �� 5)      .��6   Patient Age6!   �� 5*      -   5        $��patient_age_textbox��5*      63   �� 5+      .��6   Patient Gender6$   �� 5,      -   5        $��patient_gender_textbox��5,      66   �� 5-      .��6   Patient Address6%   �� 5.      -   5        $��patient_address_textbox��5.      67   �� 5/      .��6   Patient Phone6#   �� 50      -	   5        $��patient_phone_textbox��50      65   51      52      53      