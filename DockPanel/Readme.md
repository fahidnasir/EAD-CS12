**Introduction**

The dock panel is a layout panel, that provides an easy docking of elements to the left, right, top, bottom or center of the panel. The dock side of an element is defined by the attached property DockPanel.Dock. To dock an element to the center of the panel, it must be the last child of the panel and the LastChildFill property must be set to true.

```
<DockPanel LastChildFill="True">
    <Button Content="Dock=Top" DockPanel.Dock="Top"/>
    <Button Content="Dock=Bottom" DockPanel.Dock="Bottom"/>
    <Button Content="Dock=Left"/>
    <Button Content="Dock=Right" DockPanel.Dock="Right"/>
    <Button Content="LastChildFill=True"/>
</DockPanel>
```
Default Value of
**DockPanel.Dock** is **Left**

**Multiple elements on one side**

The dock panel layout supports multiple elements on one side. Just add two or more elements with the same dock side. The panel simply stacks them.

```
<DockPanel LastChildFill="True">
        <Button Content="Dock=Left" />
        <Button Content="Dock=Left" />
        <Button Content="Dock=Top" DockPanel.Dock="Top" />
        <Button Content="Dock=Top" DockPanel.Dock="Top" />
        <Button Content="Dock=Top" DockPanel.Dock="Top" />
        <Button Content="Dock=Bottom" DockPanel.Dock="Bottom" />
        <Button Content="Dock=Right" DockPanel.Dock="Right" />
        <Button Content="LastChildFill=True" />
</DockPanel>
```

**Change the stacking order**

The order of the elements matters. It determines the alignment of the elements. The first elements gets the whole width or height. The following elements get the remaining space.

```
<DockPanel LastChildFill="True">
        <Button DockPanel.Dock="Top" Height="50" Content="Top 1" />
        <Button DockPanel.Dock="Bottom" Height="50" Content="Bottom 1" />
        <Button DockPanel.Dock="Left" Width="50" Content="Left 1" />
        <Button DockPanel.Dock="Left" Width="50" Content="Left 2" />
        <Button DockPanel.Dock="Right" Width="50" Content="Right 1" />
        <Button DockPanel.Dock="Right" Height="50" Content="Right 2" />
</DockPanel>
```
