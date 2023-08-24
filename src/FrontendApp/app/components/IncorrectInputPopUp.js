import { AiOutlineClose } from "react-icons/ai";

const IncorrectInputPopup = ({ onClose }) => {
    return (
      <div className="fixed inset-0 flex items-center justify-center bg-opacity-60 backdrop-filter backdrop-blur z-20">
        <div className="p-4 rounded-lg w-full md:w-1/4 shadow-lg bg-green flex flex-col">
          <AiOutlineClose
            onClick={onClose}
            className="self-end cursor-pointer hover:bg-navy-blue text-3xl hover:rounded-full hover:text-green"
          />
          <div className="flex flex-col items-center">
            <h2 className="text-navy-blue text-2xl font-bold">Incorrect Input</h2>
            <button
              onClick={onClose}
              className="mt-6 px-4 py-2 rounded-full text-navy-blue font-bold bg-green hover:bg-navy-blue hover:text-green"
            >
              Close
            </button>
          </div>
        </div>
      </div>
    );
  };
  
  export default IncorrectInputPopup;
  