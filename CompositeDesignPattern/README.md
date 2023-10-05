# Composite Design Pattern

- Composite pattern is used where we need to treat a group of objects in similar way as a single object. Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchy. This type of design pattern comes under structural pattern as this pattern creates a tree structure of group of objects.
  
- In simple words, we can say that the Composite Design Pattern composes the objects in the form of a tree structure to represent part as well as a whole hierarchy. This design pattern is used when we need to treat a group of objects in a similar way as a single object.

## When do we need to use the Composite Design Pattern in C# Real-Time Applications?

  - We want to represent part-whole hierarchies of objects.
  - We want the clients to ignore the difference between the compositions of objects and individual objects.

## Real-Time Example to Understand Composite Design Pattern:

  - Now, we need to create a File and Folder structure hierarchy. In our example, if we need to store some file, then that file should be stored under some directory or you can say folder. For a better understanding, please have a look at the following image which shows the Folder and File Structure of the Root Directory. Let us assume the following is the File directory on our computer.

    ![image](https://github.com/jil1710/readmedemo/assets/125335932/18b040d6-12d3-4a64-a55a-0c6c8eaaa928)

  - Whatever you see in the above diagram, everything is an object. So, here, Root Directory, Folder1, Folder2, SubFolder1, MyBook.txt, MyVideo.mp4, MyMusic.mp3, MyResume.pdf, MySoftware.exe, and MyDocument.doc, all are objects.

  - A composite object is an object which contains other objects. The point that you need to remember is a composite object may also contain other composite objects along with leaf objects. The object which does not contain any other objects is simply treated as a leaf object.So, in our example, Root, Folder1, Folder2, and SubFolder1 are composite objects while MyBook.txt, MyVideo.mp4, MyMusic.mp3, MyResume.pdf, MySoftware.exe, and MyDocument.doc are the leaf object which is shown in the above diagram.

- Click here to see the example of Composite Pattern : [Composite Pattern](https://github.com/jil1710/DesignPattern/tree/master/CompositeDesignPattern)