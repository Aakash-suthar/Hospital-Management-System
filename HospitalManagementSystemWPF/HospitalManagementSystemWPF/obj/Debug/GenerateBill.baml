   M S B A M L   `   `   `  ����V  RHospitalManagementSystemWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HospitalManagementSystemWPFHospitalManagementSystemWPF  5   	   .    (HospitalManagementSystemWPF.GenerateBill   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:HospitalManagementSystemWPF     5   	     � Title$  GenerateBill��5   	   $	��450��6   $	��800��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��Center=�6%   .+�5      �� 
����  �$��20(�6&   .��64   Enter The Lab Report Data6O   �� 5      .��6   
Patient Id6    �� 5      -   5        $��searchid��5      6(   �� 5      -   5        
����d�
�������$��0q�5      $��5q�5      $��0,10,0,0q�5      .��5   *   Generate Bill69   �� 5      -   5        ���#8bc34a
�������$��0q�5"      $��5q�5#      $��0,10,0,0q�5$      .��5%   '   	Dashboard62   5&      �� 5'   
   $��1��6   .+�5(      �� .��6   
Bill ID:6   �� 5)      -   5        $��bill_id_show��5)      6,   �� 5*      .��6   Patient ID:6!   �� 5+      -   5        $��patient_id_show��5+      6/   �� 5,      .��6   Doctor Assigned:6&   �� 5-      -   5        $��doctor_assigned��5-      6/   �� 5.      .��6   Room Charge:6"   �� 5/      -   5        $��room_charge��5/      6+   �� 50      .��6   Lab Charge:6!   �� 51      -   5        $��
lab_charge��51      6*   �� 52      .��6   Days Admitted:6$   �� 53      -	   5        $��days_admitted��53      6-   �� 54      .��6   Total cost:6!   �� 55      -
   5        $��
total_cost��55      6*   �� 56      .��6   Patient name:6#   �� 57      -   5        $��patient_name��57      6,   58      59      5:      