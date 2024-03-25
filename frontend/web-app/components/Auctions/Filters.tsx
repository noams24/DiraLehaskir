import { useParamsStore } from "@/hooks/useParamsStore";
import { Button } from "@/components/ui/button";
import { AiOutlineClockCircle, AiOutlineSortAscending } from "react-icons/ai";
import { BsFillStopCircleFill, BsStopwatchFill } from "react-icons/bs";
import { GiFinishLine, GiFlame } from "react-icons/gi";

const pageSizeButtons = [4, 8, 12];

const orderButtons = [
  {
    label: "אלפבתי",
    icon: AiOutlineSortAscending,
    value: "make",
  },
  {
    label: "מועד סיום",
    icon: AiOutlineClockCircle,
    value: "endingSoon",
  },
  {
    label: "נוסף לאחרונה",
    icon: BsFillStopCircleFill,
    value: "new",
  },
];

const filterButtons = [
  {
    label: "מכרזים פעילים",
    icon: GiFlame,
    value: "live",
  },
  {
    label: "מסתיימים תוך 6 שעות",
    icon: GiFinishLine,
    value: "endingSoon",
  },
  {
    label: "הסתיימו",
    icon: BsStopwatchFill,
    value: "finished",
  },
];

const Filters = () => {
  const pageSize = useParamsStore((state) => state.pageSize);
  const setParams = useParamsStore((state) => state.setParams);
  const orderBy = useParamsStore((state) => state.orderBy);
  const filterBy = useParamsStore((state) => state.filterBy);

  return (
    <div className="flex justify-between items-center mb-4">
      <div>
        <span className="uppercase text-sm text-gray-500 ml-4">גודל דף</span>
        {pageSizeButtons.map((value, i) => (
          <Button
            key={i}
            onClick={() => setParams({ pageSize: value })}
            variant="secondary"
            color={`${pageSize === value ? "red" : "gray"}`}
            className="focus:ring-0"
          >
            {value}
          </Button>
        ))}
      </div>
      <div>
        <span className="uppercase text-sm text-gray-500 ml-3">מיין לפי</span>
        {orderButtons.map(({ label, icon: Icon, value }) => (
          <Button
            key={value}
            variant="secondary"
            onClick={() => setParams({ orderBy: value })}
            color={`${orderBy === value ? "red" : "gray"}`}
          >
            <Icon className="ml-3 h-4 w-4" />
            {label}
          </Button>
        ))}
      </div>
      <div>
        <span className="uppercase text-sm text-gray-500 mr-2">מיין לפי</span>
        <div className="inline-flex rounded-md shadow-sm">
          {filterButtons.map(({ label, icon: Icon, value }) => (
            <Button
              key={value}
              variant="secondary"
              onClick={() => setParams({ filterBy: value })}
              color={`${filterBy === value ? "red" : "gray"}`}
            >
              <Icon className="ml-3 h-4 w-4" />
              {label}
            </Button>
          ))}
        </div>
      </div>
    </div>
  );
};

export default Filters;
