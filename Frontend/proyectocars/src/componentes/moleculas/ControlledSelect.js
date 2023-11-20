import { Select, FormControl, InputLabel, FormHelperText } from "@mui/material";
import { Controller } from "react-hook-form";

const ControlledSelect = ({
  fieldName,
  label,
  control,
  defaultValue,
  children,
  rules,
  helperMessage,
  ...props
}) => {
  const labelId = `${fieldName}-label`;
  return (
    <Controller
      render={({ field, fieldState: { error } }) => (
        <FormControl error={error} {...props}>
          <InputLabel id={labelId}>{label}</InputLabel>
          <Select
            error={!!error}
            labelId={labelId}
            label={label}
            {...{ ...field, ...props }}
          >
            {children}
          </Select>
          {error && error.message && (
            <FormHelperText>{error.message}</FormHelperText>
          )}
        </FormControl>
      )}
      name={fieldName}
      control={control}
      rules={rules}
    />
  );
};
export default ControlledSelect;